using System.Collections.Generic;

namespace clrh81 {
    class Sample1{
        //******************************************************************
        // 以下のサンプルは、下のリストを対象にしています
        //******************************************************************
        private readonly int[] _list = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        
        //******************************************************************
        // 【判定】AnyとAllはフラグの真偽で判断される
        //******************************************************************
        public void 条件を満たす要素が含まれているか_Any() {
            var flg=false;
            foreach (var i in _list){
                if (i < 5){
                    flg = true;
                    break;
                }
            }
        }
        
        public void すべての要素が条件を満たしてるか_All() {
            var flg = true;
            foreach (var i in _list) {
                if (i < 5) {
                    flg=false;
                    break;
                }
            }
        }


        //******************************************************************
        //【集計】は結構うまく動作している
        //******************************************************************
        public void　要素のカウント_count() {
            var count = 0;
            foreach (var i in _list){
                count++;
            }
        }

        public void 要素の合計_Sum() {
            var sum = 0;
            foreach (var i in _list) {
                sum+=i;
            }
        }
        //微妙
        public void 最大値_Max() {
            var max = 0;
            foreach (var i in _list) {
                if (max < i) {
                    max = i;
                }
            }

            //これでいいんじゃ無いだろうか・・・
            //max = _list.Max();
        }



        //******************************************************************
        // 【複数の要素取得】は、微妙にWhereや～Whileに変換される
        //******************************************************************
        public void 条件を満たす要素の抽出() {
            var res = new List<int>();
            foreach (var i in _list) {
                if (i > 5) {
                    res.Add(i);
                }
            }
        }
        //微妙
        public void 先頭から３つをスキップ() {
            var res = new List<int>();
            
            var count = 0;
            foreach (var i in _list){
                if (count++ < 3){
                    continue;
                }
                res.Add(i);
            }
            
            //これでいいんじゃ無いだろうか・・・
            //res = _list.Skip(3).ToList();
        }
        //微妙
        public void 先頭から３つだけを取得() {
            var res = new List<int>();

            var count = 0;
            foreach (var i in _list) {
                if (count++ < 3) {
                    break;
                }
                res.Add(i);
            }

            //これでいいんじゃ無いだろうか・・・
            //res = _list.Take(3).ToList();
        }



    }
}
