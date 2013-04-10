using System.Collections.Generic;
using System.Linq;

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
                if (i > 5){
                    flg = true;
                    break;
                }
            }
        }
        
        public void すべての要素が条件を満たしてるか_All() {
            var flg = true;
            foreach (var i in _list) {
                if (i > 5) {
                    flg=false;
                    break;
                }
            }
        }

        public void 指定要素が含まれているかどうか_Contains() {
            var flg = false;
            foreach (var i in _list) {
                if (i == 5) {
                    flg = true;
                    break;
                }
            }

            //Containsの方が、コードの見た目的にはこっち方がいい？
            //flg = _list.Contains(5);

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
        public void 条件を満たす要素の抽出_where() {
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
            foreach (var i in _list) {
                if (count++ < 3) {
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


        //******************************************************************
        // 【単一の要素取得】これは、たぶん最初からLINQで書くだろう
        //******************************************************************
        public void 指定インデックの値取得(){
            int c = 0;
            int res;
            foreach (var i in _list) {
                if (5==c++) {
                    res = i;
                    break;
                }
            }
            //これでいいんじゃ無いだろうか・・・
            //res = _list.ElementAt(5);
        }

        public void 最初の値取得() {
            int res;
            int c = 0;
            foreach (var i in _list) {
                if (c == 0) {
                    res = i;
                    break;
                }
            }
            //これでいいんじゃ無いだろうか・・・
            //res = _list.First();
        }
        public void 最後の値取得() {
            int res = -1;
            int c = 0;
            foreach (var i in _list) {
                if (c++ == _list.Count() - 1){
                    res = i;
                    break;
                }
            }
            //これでいいんじゃ無いだろうか・・・
            //res = _list.Last();
        }
        


        //集合
        //Union	    和集合
        //Except	差集合
        //Intersect	積集合

        //ソート
        //OrderBy	昇順ソート
        //Reverse   降順ソート


        //射影
        //Select	射影
        //GroupBy   グルーピング

        //結合
        //Join	内部結合
        //Concat	連結
        //Zip マージ


    }
}
