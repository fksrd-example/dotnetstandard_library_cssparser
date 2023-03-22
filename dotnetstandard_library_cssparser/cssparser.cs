using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace cssParser
{
    public class cssParser
    {
        public static modelCSSFile parseFile(string fileName, string filePath)
        {
            int i = 0;

            modelCSSFile mCSSFile = new modelCSSFile();

            mCSSFile.fileLine = new string[256];

            mCSSFile.fileName = fileName;
            
            StreamReader sr = new StreamReader(filePath);

            do
            {

                mCSSFile.fileLine[i] = (sr.ReadLine());
                i++;

            } while (!sr.EndOfStream);

            sr.Close();

            mCSSFile.fileLength = i;

            return mCSSFile;
        }

        public static modelCSS parseFile(modelCSSFile mCSSFile)
        {
            modelCSS mCSS = new modelCSS();

            mCSS.propertyName = new List<PropertyName>();

            int propertyNameLength = 0;
            int propertyTextLength = 0;


            int mode = 0;

            String? pp = "";
            List<string> lines = new List<string>();

            int? i = mCSSFile.fileLength;

            if (i != null)
            {

                for (int j = 0; j < i; j++)
                {


                    String line = mCSSFile.fileLine[j];
                    
                    if (mode == 1)
                    {

                        if (line.Contains("}"))
                        {

                            mode = 0;

                            mCSS.propertyName.Add(new PropertyName(pp, lines));
                        } 

                        propertyTextLength++;

                        if (!line.Contains("}")) 
                        {

                            lines.Add(line);

                        }
                    }

                    if (line.Contains("{"))
                    {

                        mode = 1;

                        String? l =  line.Substring(0, line.IndexOf("{"));

                        pp = l;

                        propertyNameLength++;
                    }
                    
                }

            }

            return mCSS;

        }
    }
}
