using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using RiseFood.Core.Data;

namespace RiseFood.Catalogo.Data
{
    public class MongoContext : IUnitOfWork
    {
        public MongoContext(IConfiguration configuration)
        {
            _configuration = configuration;
            
            _commands = new List<Func<Task>>();
        }
        
        private  IMongoDatabase Database { get; set; }
        private readonly IConfiguration _configuration;
        private  List<Func<Task>> _commands;
        public   IMongoClient MongoClient { get; set; }
        public   IClientSessionHandle Session { get; set; }

        private void Configure()
        {
            if(MongoClient != null) return;
            MongoClient = new MongoClient(_configuration["MongoDbSettings:Connection"]);
            Database = MongoClient.GetDatabase(_configuration["MongoDbSettings:Database"]);
        }
        
        private async Task<int> SaveChanges()
        {
            Configure();
            using (Session = await  MongoClient.StartSessionAsync())
            {
                Session.StartTransaction();
                var commandTasks = _commands.Select(c => c());
                await Task.WhenAll(commandTasks);
                await Session.CommitTransactionAsync();
            }

            return _commands.Count;
        }

        public IMongoCollection<T> GetCollection<T>(string nameCollection)
        {
            Configure();
            return Database.GetCollection<T>(nameCollection);
        }

        public void AddCommand(Func<Task> func)
        {
            _commands.Add(func);
        }
        
        
        public async Task<bool> Commit()
        {
            return await SaveChanges() > 0;
        }
    }
}