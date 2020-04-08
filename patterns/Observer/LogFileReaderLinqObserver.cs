using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Observer
{
    //todo Разобраться с реактивным паттерном
   //public class LogFileReaderLinqObserver
   //{
   //    private readonly string _filename;
   //    private readonly Subject<string> _logEntriesSubject = new Subject<string>();

   //    public LogFileReaderLinqObserver(string filename)
   //    {
   //        _filename = filename;
   //    }

   //    public IObservable<string> NewMessages
   //    {
   //        get { return _logEntriesSubject; }
   //    }

   //    public void CheckFile()
   //    {

   //        foreach (var longEntrie in ReadNewLonEntries())
   //        {
   //            _logEntriesSubject.OnNext(longEntrie);
   //        }
   //    }
   //    private IEnumerable<string> ReadNewLonEntries()
   //    {
   //        return new List<string>
   //        {
   //            "first event",
   //            "second event",
   //            "third event"
   //        };
   //    }
   // }

   ////public class Subject<T> : IObservable<T>
   ////{
   ////    public IDisposable Subscribe(IObserver<T> observer)
   ////    {
   ////        throw new NotImplementedException();
   ////    }
   ////}

   //public class Subject<T> : IObserver<T>
   //{
   //    public void OnCompleted()
   //    {
   //        throw new NotImplementedException();
   //    }

   //    public void OnError(Exception error)
   //    {
   //        throw new NotImplementedException();
   //    }

   //    public void OnNext(T value)
   //    {
   //        Console.WriteLine();
   //    }
   //}
}
