using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLHULL
{ 
[XmlRoot("Hull")]
    public class Hull
    {
        [XmlAttribute("lVer")]
        public int Version { get; set; }

        [XmlAttribute("sID")]
        public int ID { get; set; }

        [XmlAttribute("sName")]
        public string Name { get; set; }

        [XmlAttribute("dWPMargin")]
        public double WPMargin { get; set; }

        [XmlAttribute("bAutoPlan")]
        public string AutoPlan { get; set; }

        [XmlAttribute("bAutoProfileDisplay")]
        public string AutoProfileDisplay { get; set; }

        [XmlAttribute("bAutoSection")]
        public string AutoSection { get; set; }

        [XmlAttribute("dSkinThickness")]
        public double SkinThickness { get; set; }

        [XmlAttribute("dAppAllowance")]
        public double AppAllowance { get; set; }

        [XmlElement("Plan")]
        public Plan Plan { get; set; }

        [XmlElement("Profile")]
        public Profile Profile { get; set; }

        [XmlElement("Section")]
        public Section Section { get; set; }

        [XmlElement("ProfileWind2")]
        public ProfileWind2 ProfileWind2 { get; set; }

        [XmlElement("WindageCalc")]
        public WindageCalc WindageCalc { get; set; }

        [XmlElement("Spaces")]
        public Spaces Spaces { get; set; }

        [XmlElement("Attributes")]
        public Attributes Attributes { get; set; }

        [XmlElement("WindCalc")]
        public WindCalc WindCalc { get; set; }
    }

    //public class Plan
    //{
    //    [XmlAttribute("lVer")]
    //    public int Version { get; set; }

    //    [XmlAttribute("dPort")]
    //    public double Port { get; set; }

    //    [XmlAttribute("dStbd")]
    //    public double Stbd { get; set; }

    //    [XmlAttribute("dAft")]
    //    public double Aft { get; set; }

    //    [XmlAttribute("dFwd")]
    //    public double Fwd { get; set; }

    //    [XmlElement("Outline")]
    //    public Outline Outline { get; set; }
    //}

    //public class Profile
    //{
    //    [XmlAttribute("lVer")]
    //    public int Version { get; set; }

    //    [XmlAttribute("dUpper")]
    //    public double Upper { get; set; }

    //    [XmlAttribute("dLower")]
    //    public double Lower { get; set; }

    //    [XmlAttribute("dAft")]
    //    public double Aft { get; set; }

    //    [XmlAttribute("dFwd")]
    //    public double Fwd { get; set; }

    //    [XmlElement("Outline")]
    //    public Outline Outline { get; set; }
    //}

    //public class Section
    //{
    //    [XmlAttribute("lVer")]
    //    public int Version { get; set; }

    //    [XmlAttribute("dUpper")]
    //    public double Upper { get; set; }

    //    [XmlAttribute("dLower")]
    //    public double Lower { get; set; }

    //    [XmlAttribute("dPort")]
    //    public double Port { get; set; }

    //    [XmlAttribute("dStbd")]
    //    public double Stbd { get; set; }

    //    [XmlElement("Outline")]
    //    public Outline Outline { get; set; }
    //}
    //public class Outline
    //{
    //    [XmlAttribute("lVer")]
    //    public int Version { get; set; }

    //    [XmlAttribute("sID")]
    //    public int ID { get; set; }

    //    [XmlAttribute("sName")]
    //    public string Name { get; set; }

    //    [XmlAttribute("bIsTank")]
    //    public string IsTank { get; set; }

    //    [XmlAttribute("bIsGenerated")]
    //    public string IsGenerated { get; set; }

    //    [XmlAttribute("lCondIndex")]
    //    public int CondIndex { get; set; }

    //    [XmlElement("Pgon")]
    //    public Pgon Pgon { get; set; }

    //    [XmlElement("Pline")]
    //    public Pline Pline { get; set; }
    //}
    //public class Pgon
    //{
    //    [XmlAttribute("lVer")]
    //    public int Version { get; set; }

    //    [XmlAttribute("sID")]
    //    public int ID { get; set; }

    //    [XmlAttribute("lCount")]
    //    public int Count { get; set; }

    //    [XmlAttribute("sX")]
    //    public string X { get; set; }
    //}

    //public class Pline
    //{
    //    [XmlAttribute("lVer")]
    //    public int Version { get; set; }

    //    [XmlAttribute("sID")]
    //    public int ID { get; set; }

    //    [XmlAttribute("sName")]
    //    public string Name { get; set; }

    //    [XmlElement("Vertices")]
    //    public Vertices Vertices { get; set; }
    //}
    //public class Vertices
    //{
    //    [XmlAttribute("lVer")]
    //    public int Version { get; set; }

    //    [XmlAttribute("sID")]
    //    public int ID { get; set; }

    //    [XmlAttribute("lCount")]
    //    public int Count { get; set; }
    //}
    public class ProfileWind2
    {
        [XmlAttribute("lVer")]
        public int Version { get; set; }

        [XmlElement("Prof")]
        public Prof Prof { get; set; }
    }

    public class Prof
    {
        [XmlAttribute("sName")]
        public string Name { get; set; }

        [XmlAttribute("dArea")]
        public double Area { get; set; }

        [XmlAttribute("pCenter")]
        public string Center { get; set; }

        [XmlAttribute("dShapeFactor")]
        public double ShapeFactor { get; set; }

        [XmlElement("Profile")]
        public Profile Profile { get; set; }
    }

    public class WindageCalc
    {
        [XmlAttribute("lCalcMethod")]
        public int CalcMethod { get; set; }

        [XmlAttribute("dStripSize")]
        public double StripSize { get; set; }

        [XmlAttribute("lChOption")]
        public int ChOption { get; set; }

        [XmlAttribute("lHeelOption")]
        public int HeelOption { get; set; }

        [XmlAttribute("lCLROption")]
        public int CLROption { get; set; }

        [XmlAttribute("sChHt")]
        public string ChHt { get; set; }

        [XmlAttribute("sCh")]
        public string Ch { get; set; }

        [XmlElement("Waterplane")]
        public Waterplane Waterplane { get; set; }

        [XmlElement("WindCS")]
        public WindCS WindCS { get; set; }

        [XmlElement("WPCS")]
        public WPCS WPCS { get; set; }

        [XmlElement("Wind")]
        public Wind Wind { get; set; }
    }

    //public class Spaces
    //{
    //    [XmlAttribute("lVer")]
    //    public int Version { get; set; }

    //    [XmlAttribute("sName")]
    //    public string Name { get; set; }

    //    [XmlElement("Space")]
    //    public List<Space> Space { get; set; }
    //}

    //public class Space
    //{
    //    [XmlAttribute("sName")]
    //    public string Name { get; set; }

    //    [XmlAttribute("sGroup")]
    //    public string Group { get; set; }

    //    [XmlAttribute("sID")]
    //    public int ID { get; set; }

    //    [XmlAttribute("sVolID")]
    //    public int VolID { get; set; }

    //    [XmlAttribute("sVolName")]
    //    public string VolName { get; set; }

    //    [XmlAttribute("dVolFactor")]
    //    public double VolFactor { get; set; }

    //    [XmlAttribute("dWindShapeFactor")]
    //    public double WindShapeFactor { get; set; }

    //    [XmlAttribute("lWindProtectedSideFlag")]
    //    public int WindProtectedSideFlag { get; set; }

    //    [XmlAttribute("dWindHeightFactor")]
    //    public double WindHeightFactor { get; set; }

    //    [XmlElement("Transforms")]
    //    public Transforms Transforms { get; set; }
    //}

    public class Transforms
    {
        [XmlElement("Transform")]
        public Transform Transform { get; set; }
    }

    public class Transform
    {
        [XmlAttribute("lType")]
        public int Type { get; set; }

        [XmlAttribute("lVer")]
        public int Version { get; set; }

        [XmlAttribute("sID")]
        public int ID { get; set; }

        [XmlAttribute("sMirror")]
        public string Mirror { get; set; }
    }

    public class Attributes
    {
        [XmlAttribute("lVer")]
        public int Version { get; set; }

        [XmlAttribute("sNotes")]
        public string Notes { get; set; }

        [XmlAttribute("tLastUpdated")]
        public string LastUpdated { get; set; }

        [XmlAttribute("sLastUpdatedBy")]
        public string LastUpdatedBy { get; set; }

        [XmlAttribute("bLocked")]
        public string Locked { get; set; }
    }

    public class WindCalc
    {
        [XmlAttribute("lCalcMethod")]
        public int CalcMethod { get; set; }

        [XmlAttribute("dStripSize")]
        public double StripSize { get; set; }

        [XmlAttribute("lChOption")]
        public int ChOption { get; set; }

        [XmlAttribute("lHeelOption")]
        public int HeelOption { get; set; }

        [XmlAttribute("lCLROption")]
        public int CLROption { get; set; }

        [XmlAttribute("sChHt")]
        public string ChHt { get; set; }

        [XmlAttribute("sCh")]
        public string Ch { get; set; }

        [XmlElement("Waterplane")]
        public Waterplane Waterplane { get; set; }

        [XmlElement("WindCS")]
        public WindCS WindCS { get; set; }

        [XmlElement("WPCS")]
        public WPCS WPCS { get; set; }

        [XmlElement("Wind")]
        public Wind Wind { get; set; }
    }

    public class Waterplane
    {
        [XmlAttribute("lVer")]
        public int Version { get; set; }

        [XmlAttribute("sID")]
        public int ID { get; set; }

        [XmlAttribute("sName")]
        public string Name { get; set; }

        [XmlAttribute("lType")]
        public int Type { get; set; }

        [XmlAttribute("PP0")]
        public string PP0 { get; set; }

        [XmlElement("Normal")]
        public Normal Normal { get; set; }

        [XmlElement("Attributes")]
        public Attributes Attributes { get; set; }
    }

    public class Normal
    {
        [XmlAttribute("lVer")]
        public int Version { get; set; }

        [XmlAttribute("dx")]
        public double Dx { get; set; }

        [XmlAttribute("dy")]
        public double Dy { get; set; }

        [XmlAttribute("dz")]
        public double Dz { get; set; }
    }

    public class WindCS
    {
        [XmlAttribute("lVer")]
        public int Version { get; set; }

        [XmlAttribute("sID")]
        public int ID { get; set; }

        [XmlAttribute("sName")]
        public string Name { get; set; }

        [XmlAttribute("PP0")]
        public string PP0 { get; set; }

        [XmlElement("Normal")]
        public Normal Normal { get; set; }

        [XmlElement("Attributes")]
        public Attributes Attributes { get; set; }
    }

    public class WPCS
    {
        [XmlAttribute("lVer")]
        public int Version { get; set; }

        [XmlAttribute("sID")]
        public int ID { get; set; }

        [XmlAttribute("sName")]
        public string Name { get; set; }

        [XmlAttribute("lType")]
        public int Type { get; set; }

        [XmlAttribute("PP0")]
        public string PP0 { get; set; }

        [XmlElement("Normal")]
        public Normal Normal { get; set; }

        [XmlElement("Attributes")]
        public Attributes Attributes { get; set; }
    }

    public class Wind
    {
        [XmlAttribute("lVer")]
        public int Version { get; set; }

        [XmlAttribute("sID")]
        public int ID { get; set; }

        [XmlAttribute("sName")]
        public string Name { get; set; }

        [XmlAttribute("lType")]
        public int Type { get; set; }

        [XmlAttribute("PP0")]
        public string PP0 { get; set; }

        [XmlElement("Normal")]
        public Normal Normal { get; set; }

        [XmlElement("Attributes")]
        public Attributes Attributes { get; set; }
    }

}
