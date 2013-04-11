using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace clrh81 {
//    class Sample2{
//
//
//
//        List<int> numList = new List<int>();
//
//        public IEnumerable<int> GetEvenNums() {
//            //lock (numList) {
//                return numList.Where(i => i % 2 == 0);
//            //}
//        }
//
//        public void AddNum(int num) {
//            //lock (numList) {
//                numList.Add(num);
//            //}
//        }
//
//    }
//
    class DbClass{
        List<int> _list = new List<int>();

        public IEnumerable<int> GetList() {
            //lock (numList) {
            return _list.Where(i => i % 2 == 0);
            //}
        }

        public void Add(int i) {
            //lock (numList) {
            _list.Add(i);
            //}
        }
    }

    class Sample2{
        

        
    }
}
