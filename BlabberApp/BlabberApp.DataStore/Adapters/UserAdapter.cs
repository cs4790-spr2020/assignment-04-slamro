using System;
using System.Collections;
using BlabberApp.DataStore.Interfaces;
using BlabberApp.Domain.Entities;

namespace BlabberApp.DataStore.Adapters
{
    public class UserAdapter
    {
       private IPlugin plugin;

       public UserAdapter(IPlugin plugin)
       {
           this.plugin = plugin;
       }

       public void Add(User user)
       {
           this.plugin.Create(user);
       }

       public void Remove(User user)
       {
           this.plugin.Delete(user);
       }

       public void Update(User user)
       {
           this.plugin.Update(user);
       }

       public IEnumerable GetAll()
       {
           return this.plugin.ReadAll();
       }

       public User GetById(Guid Id)
       {
           return (User)this.plugin.ReadById(Id);
       }
    }
}