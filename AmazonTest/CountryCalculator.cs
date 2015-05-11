using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonTest
{
    public class CountryCalculator
    {
        public static int CalculateCountries(int[,] map)
        {
            int countries = 0;
            int totalRows = map.GetUpperBound(0);
            int totalColumns = map.GetUpperBound(1);

            for (int row = 0; row <= totalRows; row++)
            {
                for (int column = 0; column <= totalColumns; column++)
                {
                    int currentValue = map[row, column];

                    // Check above
                    if (row > 0)
                    {
                        int valueAbove = map[row - 1, column];

                        if (valueAbove == currentValue)
                            continue;
                    }

                    // Check left
                    if (column > 0)
                    {
                        int valueLeft = map[row, column - 1];

                        if (valueLeft == currentValue)
                            continue;
                    }

                    // check if part of a country mapping up
                    if (row > 0)
                    {
                        int countryLinkColumn = partOfCountryMappingUp(currentValue, row, column, totalColumns, map);

                        if (countryLinkColumn > -1)
                        {
                            column = countryLinkColumn;
                            continue;
                        }
                    }

                    countries++;
                }
            }

            return countries;
        }

        private static int partOfCountryMappingUp(int currentValue, int currentRow, int currentColumn, int totalColumns, int[,] map)
        {
            for (int column = currentColumn+ 1; column <= totalColumns; column++)
            {
                int valueOfNewPosition = map[currentRow, column];
                int valueAbove = map[currentRow - 1, column];

                if (valueOfNewPosition != currentValue)
                    return -1;

                if (valueAbove == currentValue)
                    return column;
            }

            return -1;
        }
    }
}
