using System.Collections.Generic;
using System.Linq;

namespace clrh81 {

    class Db{
        List<int> _list = new List<int>();

        public IEnumerable<int> GetList() {
            lock (_list) {
                foreach (var i in _list){
                    if (i%2 == 0){
                        yield return i;
                    }
                }
            }
        }

        public void Add(int i) {
            lock (_list) {
                _list.Add(i);
            }
        }
    }

    class Sample2{
        public void Main(){
            var db = new Db();
            var count = db.GetList().Count();
        }
        
    }
}
