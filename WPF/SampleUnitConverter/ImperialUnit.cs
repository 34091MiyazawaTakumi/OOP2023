﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    public class ImperialUnit : DistanceUnit {  //ヤード単位を表すクラス
        private static List<ImperialUnit> units = new List<ImperialUnit> {
            new ImperialUnit { Name = "in", Coefficient = 1, },  //インチ
            new ImperialUnit { Name = "ft", Coefficient = 12, },  //フィート
            new ImperialUnit { Name = "yd", Coefficient = 12 * 3, },  //ヤード
            new ImperialUnit { Name = "ml", Coefficient = 12 * 3 * 1760, },  //マイル
        };
        public static ICollection<ImperialUnit> Units { get { return units; } }

        /// <summary>
        /// メートル単位からヤード単位に変換します
        /// </summary>
        /// <param name="unit">メートル単位</param>
        /// <param name="value">値</param>
        /// <returns>変換値</returns>
        public double FromMetricUnit(MetricUnit unit, double value){
            return (value * unit.Coefficient) / 25.4 / this.Coefficient;
        }
    }
}
