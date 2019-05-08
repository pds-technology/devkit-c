using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevkitTest
{


    public enum EPCRelationshipType
    {
        destinationObject,
        sourceObject,
        mlToExternalPartProxy,
        extenalPartProxyToMI,
        externalResource,
        destinationMedia,
        sourceMedia,
        chunkedPart,
        others
    }


    class EPCPartValidator
    {
        readonly static string epccontent = "application/x-";
        readonly static string epcversion = "version=";
        readonly static string epctype = "type=";
        readonly static string relationshipURL = "http://schemas.energistics.org/package/2012/relationships/";
        // the EPC package must follow <objectType>_<uuid>.xml
        private static String[] parseFileNameName(string filename)
        {
            String[] names = null;
            bool objflag = false;
            if (filename.Contains("obj_"))
            {
                objflag = true;
                filename = filename.Replace("obj_", "");
            }
            names = filename.Replace(".xml","").Split('_');
            if((names==null)||(names.Length!=2))
                return null;
            if (objflag)
                names[0] = "obj_" + names[0];            
            return names;
        }

        // EPC contenttype must following the following rule:
        // application/x-<energisticsStandar>+xml;version=<versionName>;type=<objectType>
        public static Boolean parseContentType(String contenttype, ref String energistcsStandard, ref String version, ref String energisticsObjectName)
        {
            string[] names = contenttype.Split(';');
            if((names==null)||(names.Length != 3)) return false;
            if (names[0].Trim().StartsWith(epccontent))
            {
                int pos = names[0].IndexOf("+xml");
                if (pos <= 0) return false;
                energistcsStandard = names[0].Substring(epccontent.Length, pos - epccontent.Length).Trim();
            }
            if (names[1].Trim().StartsWith(epcversion))
            {
                version = names[1].Substring(epcversion.Length+1).Trim();
            }
            if (names[2].Trim().StartsWith(epctype))
            {
                energisticsObjectName = names[2].Substring(epctype.Length+1).Trim();
            }
            return true;
        }

    
     
        private static bool verifyUUID(string uuid)
        {
            if (uuid == null) throw new ArgumentNullException("guidString");
            try
            {
                Guid guid = new Guid(uuid);
                return true;
            }
            catch (FormatException)
            { 
                return false;
            }
        }

        internal static string getUUID(string filename)
        {
            String[] names = parseFileNameName(filename);
            if ((names == null)||!verifyUUID(names[1]))
                throw new FormatException();
            return names[1];
        }

        internal static string getEnergisticsObjectName(string name)
        {
            String[] names = parseFileNameName(name);
            if (names == null) throw new FormatException();
            return names[0];
        }

        /// <summary>
        /// validate the file name following the energistics naming rule
        /// the EPC package must follow <objectType>_<uuid>.xml
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        internal static bool validateName(string name)
        {
            if (parseFileNameName(name) != null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// return relationship type. 
        /// EPC RelationshipType is one of following type:
        /// destinationObject 
        /// sourceObject
        ///mlToExternalPartProxy
        ///extenalPartProxyTOMI
        ///externalResource
        ///destinationMedia
        ///sourceMedia
        ///chunkedPart
        /// </summary>
        /// <param name="relationshipType"></param>
        /// <returns></returns>
        internal static EPCRelationshipType getRelationshipType(string relationshipType)
        {
            if (relationshipType.Contains(relationshipURL))
            {
                String relTypename = relationshipType.Replace(relationshipURL, "");
                if (relTypename.Equals(EPCRelationshipType.destinationObject.ToString()))
                    return EPCRelationshipType.destinationObject;
                if (relTypename.Equals(EPCRelationshipType.mlToExternalPartProxy.ToString()))
                    return EPCRelationshipType.mlToExternalPartProxy;
                if (relTypename.Equals(EPCRelationshipType.externalResource.ToString()))
                    return EPCRelationshipType.externalResource;
                if (relTypename.Equals(EPCRelationshipType.chunkedPart.ToString()))
                    return EPCRelationshipType.chunkedPart;
                if (relTypename.Equals(EPCRelationshipType.destinationObject.ToString()))
                    return EPCRelationshipType.destinationObject;
                if (relTypename.Equals(EPCRelationshipType.extenalPartProxyToMI.ToString()))
                    return EPCRelationshipType.extenalPartProxyToMI;
                if (relTypename.Equals(EPCRelationshipType.others.ToString()))
                    return EPCRelationshipType.others;
                if (relTypename.Equals(EPCRelationshipType.sourceMedia.ToString()))
                    return EPCRelationshipType.sourceMedia;
                if (relTypename.Equals(EPCRelationshipType.sourceObject.ToString()))
                    return EPCRelationshipType.sourceObject;
            }
            return EPCRelationshipType.others;
           
        }
    }
}
