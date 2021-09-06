using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Blazored.LocalStorage;

namespace Beam.Tests
{
    public class TestLocalStorage : ILocalStorageService
    {
        private Dictionary<string, object> dictionary = new Dictionary<string, object>();

        public event EventHandler<ChangingEventArgs> Changing;
        public event EventHandler<ChangedEventArgs> Changed;

        public ValueTask ClearAsync(CancellationToken? cancellationToken = null)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> ContainKeyAsync(string key, CancellationToken? cancellationToken = null)
        {
            throw new NotImplementedException();
        }

        public ValueTask<string> GetItemAsStringAsync(string key, CancellationToken? cancellationToken = null)
        {
            throw new NotImplementedException();
        }

        public ValueTask<T> GetItemAsync<T>(string key, CancellationToken? cancellationToken = null)
        {
            if (dictionary.ContainsKey(key))
            {
                return  new ValueTask<T>( (T)dictionary[key]);
            }
            else
            {
                return new ValueTask<T>( default(T));
            }

        }

        public ValueTask<string> KeyAsync(int index, CancellationToken? cancellationToken = null)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> LengthAsync(CancellationToken? cancellationToken = null)
        {
            throw new NotImplementedException();
        }

        public ValueTask RemoveItemAsync(string key, CancellationToken? cancellationToken = null)
        {
            throw new NotImplementedException();
        }

        public ValueTask SetItemAsStringAsync(string key, string data, CancellationToken? cancellationToken = null)
        {
            throw new NotImplementedException();
        }

        public ValueTask SetItemAsync<T>(string key, T data, CancellationToken? cancellationToken = null)
        {
            Changing?.Invoke( this, new ChangingEventArgs() { Key = key, NewValue = data});
            dictionary[key] = data;
            Changed?.Invoke(this, new ChangedEventArgs() { Key = key, NewValue = data });
            return new ValueTask();
        }
    }
}
