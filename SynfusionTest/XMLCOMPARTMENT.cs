using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLCOMPARTMENT
{
[XmlRoot(ElementName = "Compartments")]
    public class Compartments
    {
        [XmlAttribute(AttributeName = "lVer")]
        public int Version { get; set; }

        [XmlAttribute(AttributeName = "sID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Compartment")]
        public List<Compartment> CompartmentList { get; set; }
    }

    public class Compartment
    {
        [XmlAttribute(AttributeName = "lVer")]
        public int Version { get; set; }

        [XmlAttribute(AttributeName = "sID")]
        public int ID { get; set; }

        [XmlAttribute(AttributeName = "sName")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "lIndex")]
        public int Index { get; set; }

        [XmlAttribute(AttributeName = "sShortName")]
        public string ShortName { get; set; }

        [XmlAttribute(AttributeName = "sGroup")]
        public string Group { get; set; }

        [XmlAttribute(AttributeName = "dDensity")]
        public double Density { get; set; }

        [XmlAttribute(AttributeName = "lIMOType")]
        public int IMOType { get; set; }

        [XmlAttribute(AttributeName = "lSpaceType")]
        public int SpaceType { get; set; }

        [XmlAttribute(AttributeName = "lFloodType")]
        public int FloodType { get; set; }

        [XmlAttribute(AttributeName = "bAutoPlan")]
        public string AutoPlan { get; set; }

        [XmlAttribute(AttributeName = "bAutoProfile")]
        public string AutoProfile { get; set; }

        [XmlAttribute(AttributeName = "bAutoSection")]
        public string AutoSection { get; set; }

        [XmlAttribute(AttributeName = "lFSCalcOption")]
        public int FSCalcOption { get; set; }

        [XmlAttribute(AttributeName = "dFSHeelAngleDeg")]
        public double FSHeelAngleDeg { get; set; }

        [XmlAttribute(AttributeName = "bFSIncludePerm")]
        public string FSIncludePerm { get; set; }

        [XmlAttribute(AttributeName = "dFSTNearFull")]
        public double FSTNearFull { get; set; }

        [XmlAttribute(AttributeName = "dFSTNearEmpty")]
        public double FSTNearEmpty { get; set; }

        [XmlAttribute(AttributeName = "dFSTSlack")]
        public double FSTSlack { get; set; }

        [XmlAttribute(AttributeName = "dFSTSlackH")]
        public double FSTSlackH { get; set; }

        [XmlAttribute(AttributeName = "dFSTSlackVol")]
        public double FSTSlackVol { get; set; }

        [XmlAttribute(AttributeName = "dFSLNearFull")]
        public double FSLNearFull { get; set; }

        [XmlAttribute(AttributeName = "dFSLNearEmpty")]
        public double FSLNearEmpty { get; set; }

        [XmlAttribute(AttributeName = "dFSLSlack")]
        public double FSLSlack { get; set; }

        [XmlAttribute(AttributeName = "dFSLSlackH")]
        public double FSLSlackH { get; set; }

        [XmlAttribute(AttributeName = "dFSLSlackVol")]
        public double FSLSlackVol { get; set; }

        [XmlAttribute(AttributeName = "dPermeability")]
        public double Permeability { get; set; }

        [XmlAttribute(AttributeName = "bCustomRenderingEnabled")]
        public string CustomRenderingEnabled { get; set; }

        [XmlAttribute(AttributeName = "lCustomRenderingColor")]
        public int CustomRenderingColor { get; set; }

        [XmlAttribute(AttributeName = "dCustomRenderingTransparency")]
        public double CustomRenderingTransparency { get; set; }

        [XmlElement(ElementName = "Plan")]
        public Plan Plan { get; set; }

        [XmlElement(ElementName = "Profile")]
        public Profile Profile { get; set; }

        [XmlElement(ElementName = "Section")]
        public Section Section { get; set; }

        [XmlElement(ElementName = "Spaces")]
        public Spaces Spaces { get; set; }
    }

    public class Plan
    {
        [XmlAttribute(AttributeName = "lVer")]
        public int Version { get; set; }

        [XmlAttribute(AttributeName = "dPort")]
        public double Port { get; set; }

        [XmlAttribute(AttributeName = "dStbd")]
        public double Stbd { get; set; }

        [XmlAttribute(AttributeName = "dAft")]
        public double Aft { get; set; }

        [XmlAttribute(AttributeName = "dFwd")]
        public double Fwd { get; set; }

        [XmlElement(ElementName = "Outline")]
        public Outline Outline { get; set; }
    }

    public class Outline
    {
        [XmlAttribute(AttributeName = "lVer")]
        public int Version { get; set; }

        [XmlAttribute(AttributeName = "sID")]
        public int ID { get; set; }

        [XmlAttribute(AttributeName = "sName")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "bIsTank")]
        public string IsTank { get; set; }

        [XmlAttribute(AttributeName = "bIsGenerated")]
        public string IsGenerated { get; set; }

        [XmlAttribute(AttributeName = "lCondIndex")]
        public int CondIndex { get; set; }

        [XmlElement(ElementName = "Pgon")]
        public Pgon Pgon { get; set; }

        [XmlElement(ElementName = "Pline")]
        public Pline Pline { get; set; }
    }

    public class Pgon
    {
        [XmlAttribute(AttributeName = "lVer")]
        public int Version { get; set; }

        [XmlAttribute(AttributeName = "sID")]
        public int ID { get; set; }

        [XmlAttribute(AttributeName = "lCount")]
        public int Count { get; set; }

        [XmlAttribute(AttributeName = "sX")]
        public string XCoordinates { get; set; }

        [XmlAttribute(AttributeName = "sY")]
        public string YCoordinates { get; set; }
    }

    public class Pline
    {
        [XmlAttribute(AttributeName = "lVer")]
        public int Version { get; set; }

        [XmlAttribute(AttributeName = "sID")]
        public int ID { get; set; }

        [XmlAttribute(AttributeName = "sName")]
        public string Name { get; set; }

        [XmlElement(ElementName = "Vertices")]
        public Vertices Vertices { get; set; }
    }

    public class Vertices
    {
        [XmlAttribute(AttributeName = "lVer")]
        public int Version { get; set; }

        [XmlAttribute(AttributeName = "sID")]
        public int ID { get; set; }

        [XmlAttribute(AttributeName = "lCount")]
        public int Count { get; set; }
    }

    public class Profile
    {
        [XmlAttribute(AttributeName = "lVer")]
        public int Version { get; set; }

        [XmlAttribute(AttributeName = "dUpper")]
        public double Upper { get; set; }

        [XmlAttribute(AttributeName = "dLower")]
        public double Lower { get; set; }

        [XmlAttribute(AttributeName = "dAft")]
        public double Aft { get; set; }

        [XmlAttribute(AttributeName = "dFwd")]
        public double Fwd { get; set; }

        [XmlElement(ElementName = "Outline")]
        public Outline Outline { get; set; }
    }

    public class Section
    {
        [XmlAttribute(AttributeName = "lVer")]
        public int Version { get; set; }

        [XmlAttribute(AttributeName = "dUpper")]
        public double Upper { get; set; }

        [XmlAttribute(AttributeName = "dLower")]
        public double Lower { get; set; }

        [XmlAttribute(AttributeName = "dPort")]
        public double Port { get; set; }

        [XmlAttribute(AttributeName = "dStbd")]
        public double Stbd { get; set; }

        [XmlElement(ElementName = "Outline")]
        public Outline Outline { get; set; }
    }

    public class Spaces
    {
        [XmlAttribute(AttributeName = "sName")]
        public string Name { get; set; }

        [XmlElement(ElementName = "Space")]
        public Space Space { get; set; }
    }

    public class Space
    {
        [XmlAttribute(AttributeName = "sName")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "sGroup")]
        public string Group { get; set; }

        [XmlAttribute(AttributeName = "sID")]
        public int ID { get; set; }

        [XmlAttribute(AttributeName = "sVolID")]
        public int VolID { get; set; }

        [XmlAttribute(AttributeName = "sVolName")]
        public string VolName { get; set; }

        [XmlAttribute(AttributeName = "dVolFactor")]
        public double VolFactor { get; set; }

        [XmlAttribute(AttributeName = "sVolShortName")]
        public string VolShortName { get; set; }

        [XmlAttribute(AttributeName = "dPermeability")]
        public double Permeability { get; set; }

        [XmlAttribute(AttributeName = "bCustomRenderingEnabled")]
        public string CustomRenderingEnabled { get; set; }

        [XmlAttribute(AttributeName = "lCustomRenderingColor")]
        public int CustomRenderingColor { get; set; }

        [XmlAttribute(AttributeName = "dCustomRenderingTransparency")]
        public double CustomRenderingTransparency { get; set; }
    }

}
