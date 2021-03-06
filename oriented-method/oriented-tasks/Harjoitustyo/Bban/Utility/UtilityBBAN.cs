﻿using System;

namespace DigiTrade.Utility
{
    public class UtilityBBAN
    {       
        /// <summary>
        /// Change account to machineformat
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns>machineformat account</returns>
        public static bool CorrectNumber(ref string accountNumber)
        {
            accountNumber = accountNumber.Replace("-", "").Replace(" ", "");
            for (int i = 0; i < accountNumber.Length; i++)
            {
                bool isDigit = int.TryParse(accountNumber[i].ToString(), out int digit);
                if (!isDigit)
                    return false;
            }

            int positionOfZeros = 0;

            if (accountNumber[0] == '1' || accountNumber[0] == '2' ||
                accountNumber[0] == '6' || accountNumber[0] == '8')
                positionOfZeros = 6;
            else if (accountNumber[0] == '3')
            {
                if (accountNumber[1] == '0' || accountNumber[1] == '2' || accountNumber[1] == '5')
                    return false;
                positionOfZeros = 6;
            }
            else if (accountNumber[0] == '4' || accountNumber[0] == '5')
                positionOfZeros = 7;
            else
            {
                return false;
            }

            while (accountNumber.Length < 14)
            {
                accountNumber = accountNumber.Insert(positionOfZeros, "0");
            }

            return true;
        }

        public static bool IsValidAccount(string machineFormatAccount)
        {
            int checkNumber = int.Parse(machineFormatAccount[machineFormatAccount.Length - 1].ToString());

            machineFormatAccount = machineFormatAccount.Remove(machineFormatAccount.Length - 1, 1);
            int[] multiplex = new int[2] { 2, 1 };
            int m = 0;
            for (int i = 0; i < machineFormatAccount.Length; i++)
            {
                bool isInt = int.TryParse(machineFormatAccount[i].ToString(), out int digitResult);
                if (!isInt)
                    return false;
                int n = digitResult * multiplex[i % 2];
                if (n >= 10)
                    m += n / 10 + (n - 10);
                else
                    m += n;
            }

            int calculatedCheckNumber = ((m / 10 + 1) * 10) - m;

            return checkNumber == calculatedCheckNumber;

            //if (checkNumber == calculatedCheckNumber)
            //    return true;
            //else
            //{
            //    return false;
            //}


        }
    }
}
