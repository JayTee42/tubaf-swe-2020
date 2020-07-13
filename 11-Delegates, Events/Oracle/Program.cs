using System;

namespace SportsOracle
{
    class Program
    {
        private delegate void OracleFunc(string msg);

        private static OracleFunc BuildOracle(bool includeExtraTime, bool includeRedCards)
        {
            OracleFunc oracle = Oracle.PredictResult;

            if (includeExtraTime)
            {
                oracle += Oracle.PredictExtraTime;
            }

            if (includeRedCards)
            {
                oracle += Oracle.PredictRedCards;
            }

            return oracle;
        }

        static void Main(string[] args)
        {
            OracleFunc oracle = BuildOracle(true, true);

            oracle("Germany - Italy");
            oracle("Germany - Italy");
            oracle("Germany - Italy");
            oracle("Germany - France");
            oracle("Brazil - Algeria");
        }
    }
}
