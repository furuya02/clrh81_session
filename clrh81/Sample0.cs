using System.Collections.Generic;

namespace clrh81 {
    class Sample0 {
        
        private int[] _list = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public void Sample_000(){
            var ar = new List<int>();
            foreach (var i in _list){
                if (i%2 == 0 && i < 5)
                    ar.Add(i);
            }
        }

        public void Sample_001() {
            var ar = new List<int>();
            foreach (var i in _list) {
                if (i % 2 == 0) {
                    foreach (var n in _list){
                        if(n==i){
                            ar.Add(i);
                        }
                    
                    }
                }
            }
        }


        class OneRR{
            public int DnsType { get; set; }
            public bool IsEffective{get; set; }
            public string Name { get; set; }
            public string Data { get; set; }
        }

        public string Sample_002() {
            var log = "";
            var db = new List<OneRR>();
            foreach (var oneRr in db) {
                if (oneRr.DnsType == 1) {
                    if (!oneRr.IsEffective)
                        continue;
                    if (oneRr.Name.ToUpper() == "ABC") {
                        var find = false;
                        foreach (var o in db) {
                            if (o.Data == oneRr.Data) {
                                find = true;
                                break;
                            }
                        }
                        if (!find) {
                            log="Success data search.";

                        }
                    }
                }
            }
            return log;
        }
        
    }
}
