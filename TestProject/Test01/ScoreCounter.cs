using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }

        //メソッドの概要： 点数データを読み込み、Studentオブジェクトのリストを返す
        private static IEnumerable<Student> ReadScore(string filePath) {
            var scores = new List<Student>();  //点数データを格納する
            var lines = File.ReadAllLines(filePath);  //ファイルからすべてのデータを読み込む

            foreach (var line in lines) {  //すべての行から一行ずつ取り出す
                var items = line.Split(',');
                var student = new Student {  //studentインスタンスを生成
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                scores.Add(student);  //Studentインスタンスをコレクションに追加
            }
            return scores;
        }

        //メソッドの概要： 科目別の点数の集計を求める
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();

            foreach (var scores in _score) {
                if (dict.ContainsKey(scores.Subject))
                    dict[scores.Subject] += scores.Score;  //科目名が既に存在する（加算）
                else
                    dict[scores.Subject] = scores.Score;  //科目名が存在しない（新規作成）
            }
            return dict;
        }
    }
}
