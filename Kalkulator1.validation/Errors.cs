using System;
using System.Collections.Generic;

namespace Kalkulator1.validation
{
	public class Errors
	{
		private List<string> hardErrors;
		private List<string> hardWarning;
		private List<string> SoftErrors;
		public Errors()
		{
			this.hardErrors = new List<string>();
			this.hardWarning = new List<string>();
			this.SoftErrors = new List<string>();
		}
		public void addHardError(string error)
		{
			this.hardErrors.Add(error);
		}
		public void addHardWarning(string error)
		{
			this.hardWarning.Add(error);
		}
		public void addSoftError(string error)
		{
			this.SoftErrors.Add(error);
		}
		public string getHardErrorXml()
		{
			string r = "";
			for (int i = 0; i < this.hardErrors.Count; i++)
			{
				if (this.hardErrors[i] != "")
				{
					r = r + "<code>" + this.hardErrors[i] + "</code>";
				}
			}
			return r;
		}
		public string getHardWarningXml()
		{
			string r = "";
			for (int i = 0; i < this.hardWarning.Count; i++)
			{
				if (this.hardWarning[i] != "")
				{
					r = r + "<code>" + this.hardWarning[i] + "</code>";
				}
			}
			return r;
		}
		public string getSoftErrorXml()
		{
			string r = "";
			for (int i = 0; i < this.SoftErrors.Count; i++)
			{
				if (this.SoftErrors[i] != "")
				{
					r = r + "<code>" + this.SoftErrors[i] + "</code>";
				}
			}
			return r;
		}

		public void addValueInHardError(string value)
		{
			for (int i = 0; i < this.hardErrors.Count; i++)
			{
				if (this.hardErrors[i] == value)
				{
					return;
				}
			}
			this.hardErrors.Add(value);
		}

		public void addValueInHardWarning(string value)
		{
			for (int i = 0; i < this.hardWarning.Count; i++)
			{
				if (this.hardWarning[i] == value)
				{
					return;
				}
			}
			this.hardWarning.Add(value);
		}
		public void addValueInSoftError(string value)
		{
			for (int i = 0; i < this.SoftErrors.Count; i++)
			{
				if (this.SoftErrors[i] == value)
				{
					return;
				}
			}
			this.SoftErrors.Add(value);
		}
	}
}
