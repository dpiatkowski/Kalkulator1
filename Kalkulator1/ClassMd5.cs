using System;
using System.Security.Cryptography;
using System.Text;

namespace Kalkulator1
{
	internal class ClassMd5
	{
		public string CreateMD5Hash(string input)
		{
			MD5 md5 = MD5.Create();
			byte[] inputBytes = Encoding.ASCII.GetBytes(input);
			byte[] hashBytes = md5.ComputeHash(inputBytes);
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < hashBytes.Length; i++)
			{
				sb.Append(hashBytes[i].ToString("X2"));
			}
			return sb.ToString();
		}

		public string CreateMD5Hash2(string input)
		{
			MD5 md5 = MD5.Create();
			byte[] inputBytes = Encoding.UTF8.GetBytes(input);
			byte[] hashBytes = md5.ComputeHash(inputBytes);
			return System.BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
		}
	}
}
