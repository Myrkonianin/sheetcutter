/*
 * SerikOFF created this class in 16.12.2018
 */
using System;

namespace SheetCutter
{
	public class Settings{
		public string codeName="kotokopterImage";
		public string pathToSave = "out/";
		
		public string lastName(string path){
			string[] pipiska = path.Split('\\');
			return pipiska[pipiska.Length-1];
		}
	}
}
