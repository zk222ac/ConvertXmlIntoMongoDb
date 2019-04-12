using System;
using System.Xml;

namespace ConvertXmlIntoMongoDb
{
    class Program
    {
        static void Main(string[] args)
        {
            Xml2MongoDoc();
            Console.WriteLine("Hello World!");
            Console.ReadKey();

        }
        private static void Xml2MongoDoc()
        {
            MongoDataContext ctx = new MongoDataContext();
            LvsMeasurementResult lvsMeasurmentResault = new LvsMeasurementResult();
            XmlReader lvsXmlReader = XmlReader.Create("../../LVS.xml");
            int i = 0;

            while (lvsXmlReader.Read())
            {
                if (lvsXmlReader.NodeType == XmlNodeType.Element)
                {
                    if (lvsXmlReader.Name == "MaalestedId")
                    {
                        lvsMeasurmentResault.PlaceId = lvsXmlReader.ReadElementContentAsString();
                    }
                    if (lvsXmlReader.Name == "Maalested")
                    {
                        lvsMeasurmentResault.Place = lvsXmlReader.ReadElementContentAsString();
                    }
                    if (lvsXmlReader.Name == "DatoMaerke")
                    {
                        lvsMeasurmentResault.TimeStamp = lvsXmlReader.ReadElementContentAsDateTime();
                    }
                    if (lvsXmlReader.Name == "StofId")
                    {
                        lvsMeasurmentResault.StuffId = lvsXmlReader.ReadElementContentAsString();
                    }
                    if (lvsXmlReader.Name == "StofNavn")
                    {
                        lvsMeasurmentResault.StuffName = lvsXmlReader.ReadElementContentAsString();
                    }
                    if (lvsXmlReader.Name == "EnhedId")
                    {
                        lvsMeasurmentResault.UnitId = lvsXmlReader.ReadElementContentAsString();
                    }
                    if (lvsXmlReader.Name == "Enhed")
                    {
                        lvsMeasurmentResault.UnitValue = lvsXmlReader.ReadElementContentAsString();
                    }
                    if (lvsXmlReader.Name == "Resultat")
                    {
                        lvsMeasurmentResault.Result = lvsXmlReader.ReadElementContentAsFloat();
                    }
                    if (lvsXmlReader.Name == "UdstyrId")
                    {
                        lvsMeasurmentResault.EquipmentId = lvsXmlReader.ReadElementContentAsString();
                    }
                    if (lvsXmlReader.Name == "Navn")
                    {
                        lvsMeasurmentResault.EquipmentName = lvsXmlReader.ReadElementContentAsString();
                       // ctx.LvsMeasurmentResaults.InsertOne(lvsMeasurmentResault);
                    }
                    ctx.LvsMeasurmentResaults.InsertOne(lvsMeasurmentResault);
                   
                }

                Console.WriteLine("wait now Inserting document count down start now......" + i++);
                i++;
            }
            Console.WriteLine(i);
        }
    }
}
