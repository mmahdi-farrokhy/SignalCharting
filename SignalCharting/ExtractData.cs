using System.Linq;

namespace SignalCharting
{
    public static class ExtractData
    {

        public static int countRows(string textData)
        {
            return textData.Split('\n').Count();
        }

        public static int countSamples(string[] rows)
        {
            return (rows.Count()) - 1;
        }

        public static int countColumns(string[] rows, int rowIndex)
        {
            return rows[rowIndex].Trim().Split(' ').Count();
        }

        public static string[] readLines(string textData)
        {
            return textData.Split('\n');
        }

        public static string[] getHeaders(string textData)
        {
            return readLines(textData)[0].Trim().Split(' ');
        }

        public static string[] getColumnData(string textData, int columnIndex)
        {
            string[] rows = readLines(textData);
            int numOfSamples = countSamples(rows);
            string[] columnData = new string[numOfSamples];

            for (int sampleNumber = 1; sampleNumber < numOfSamples; sampleNumber++)
                columnData[sampleNumber - 1] = rows[sampleNumber].Trim().Split(' ')[columnIndex];

            return columnData;
        }

        public static bool correctFile(string textData)
        {
            return dataFormatIsCorrect(textData) && columnsNumberIsCorrect(textData);
        }

        public static bool dataFormatIsCorrect(string textData)
        {
            double numericValue;
            string[] rows = readLines(textData);
            bool firstRowIsCharacter = !double.TryParse(rows[0].Split(' ')[0], out numericValue);
            bool secondRowIsNumber = double.TryParse(rows[1].Split(' ')[0], out numericValue);
            return firstRowIsCharacter && secondRowIsNumber;
        }

        private static bool columnsNumberIsCorrect(string textData)
        {
            string[] rows = readLines(textData);
            int numOfColumns = countColumns(rows, 0);
            int numOfRows = countRows(textData);
            int numOfCorrectRows = 0;

            for (int rowIndex = 0; rowIndex < numOfRows; rowIndex++)
            {
                if (countColumns(rows, rowIndex) == numOfColumns)
                    numOfCorrectRows++;
                else
                    break;
            }

            if (numOfCorrectRows == numOfRows)
                return true;
            else
                return false;
        }
    }
}
