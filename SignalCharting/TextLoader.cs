using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace SignalCharting
{
    // read from .txt file
    public static class TextLoader
    {
        // count number of all lines
        public static int countRows(string[] rows)
        {
            return rows.Length;
        }

        // count number of samples
        public static int countSamples(string[] rows)
        {
            return countRows(rows) - 1;
        }

        // count number of columns
        public static int countColumns(string[] rows, int rowIndex)
        {
            int numOfColumns = 0;

            //rows[0].Split(' ').Count()
            foreach (char toFind in rows[rowIndex])
                if (toFind == ' ')
                    numOfColumns++;

            return numOfColumns;
        }

        // reads the .txt file line by line
        public static string[] readLines(string fileName)
        {
            LinkedList<string> rowsList = new LinkedList<string>();
            string row = "";
            const Int32 BufferSize = 128;

            using (var fileStream = File.OpenRead(fileName))
            using (StreamReader file = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                while ((row = file.ReadLine()) != null)
                {
                    rowsList.AddLast(row);
                }
            }

            return rowsList.ToArray<string>();
        }

        // read the title of each column
        public static string[] getHeaders(string[] rows)
        {
            return rows[0].Split(' ');
        }

        // returns the selected column as string array
        public static string[] getColumnData(string[] rows, int columnIndex)
        {
            int numOfSamples = countSamples(rows);
            string[] columnData = new string[numOfSamples];

            for (int sampleNumber = 1; sampleNumber < numOfSamples; sampleNumber++)
                columnData[sampleNumber] = rows[sampleNumber].Split(' ')[columnIndex];

            return columnData;
        }

        public static bool correctFile(string[] rows)
        {
            return dataFormatIsCorrect(rows) && columnsNumberIsCorrect(rows);
        }

        public static bool dataFormatIsCorrect(string[] rows)
        {
            double numericValue;
            bool firstRowIsCharacter = !(double.TryParse(rows[0].Split(' ')[0], out numericValue));
            bool secondRowIsNumber = double.TryParse(rows[1].Split(' ')[0], out numericValue);
            return firstRowIsCharacter && secondRowIsNumber;
        }

        private static bool columnsNumberIsCorrect(string[] rows)
        {
            int numOfColumns = countColumns(rows, 0);
            int numOfRows = countRows(rows);
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