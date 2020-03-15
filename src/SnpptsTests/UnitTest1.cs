//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Snppts.Infrastructure;
//using System.Linq;
//using System.Collections.Generic;
//using System;

//namespace SnpptsTests
//{
//    [TestClass]
//    public class UnitTest1
//    {
//        [TestMethod]
//        public void TestPossibleInconsistencyRepoName()
//        {
//            //var bType = typeof(IAmASnippet);
//            //var bClass = (ClassB)Activator.CreateInstance(bType);

//            var type = typeof(IAmASnippet);
//            //var types = type.Assembly.GetTypes()
//            //    .Where(p => type.IsAssignableFrom(p)).ToList();

//            //var results = from a in type.Assembly.GetTypes()
//            //              where typeof(IAmASnippet).IsAssignableFrom(a)
//            //              select a;

//            //var type = typeof(IAmASnippet);
//            //var types = type.Assembly.GetTypes()
//            //    .Where(p => type.IsAssignableFrom(p)).GetType();


//            var a = type.Assembly.GetTypes()
//                .Where(x => typeof(IAmASnippet).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract).ToList();
//                //.Select(x => x.GetInterfaces());
//                //.ToList();
//                //.Select(x => x.Name).ToList();

//        }
//    }
//}
