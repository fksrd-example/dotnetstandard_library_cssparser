using System;
using System.IO;

namespace cssParser
{
    public class parser
    {

        public static void toString() 
        {
        


        }

        public static modelCSSFile parseFile(String fileName, String filePath) 
        {

            modelCSSFile mCSSFile = new modelCSSFile();

            if (fileName != null && filePath != null)
            {

                mCSSFile = cssParser.parseFile(fileName, filePath);

            }

            return mCSSFile;
        
        }

        public static modelCSS parseCSS(modelCSSFile mCSSFile)
        {

            modelCSS mCSS = new modelCSS();

            if (mCSSFile != null)
            {

                mCSS = cssParser.parseFile(mCSSFile);

            }

            return mCSS;

        }

    }

}
