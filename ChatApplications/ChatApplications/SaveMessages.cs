using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using ChatApplications.Models;
using System.Text;

namespace ChatApplications
{
	public class SaveMessages
	{
		public void SaveMessage(string message) {


			string fileName = @"C:\Messages.txt";
			string textToAdd = message;
			FileStream fs = null;
			try
			{
				fs = new FileStream(fileName,FileMode.Append);
				using (StreamWriter writer = new StreamWriter(fs))
				{
						writer.WriteLine(textToAdd+"|");
				}
			}
			finally
			{
				if (fs != null)
					fs.Dispose();
			}

			
		}

		public string ChatHistory()
		{
			string fileName = @"C:\Messages.txt";
			string s = "";

			using (StreamReader sr = File.OpenText(fileName))
			{
				StringBuilder stringBuilder = new StringBuilder();
				

				while ((s = sr.ReadLine()) != null)
				{
					stringBuilder.AppendLine(s);
					
				}
				 
				s = stringBuilder.ToString();
			}
			
			return s;
		}
	}
}
