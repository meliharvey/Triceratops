﻿using System;
using System.Drawing;

using Grasshopper.Kernel;

namespace triceratops
{
    public class glTF_exporterInfo : GH_AssemblyInfo
  {
    public override string Name
    {
        get
        {
            return "Triceratops";
        }
    }
    public override Bitmap Icon
    {
        get
        {
            //Return a 24x24 pixel bitmap to represent this GHA library.
            return null;
        }
    }

    public override string Description
    {
        get
        {
            //Return a short string describing the purpose of this GHA library.
            return "Triceratops builds a Three.js scene from Grasshopper geometry.";
        }
    }
    public override Guid Id
    {
        get
        {
            return new Guid("19f16814-d6b1-419d-a5f3-462c72299faf");
        }
    }

    public override string AuthorName
    {
        get
        {
            //Return a string identifying you or your company.
            return "Amelia Harvey";
        }
    }
    public override string AuthorContact
    {
        get
        {
            //Return a string representing your preferred contact details.
            return "meliharvey87@gmail.com";
        }
    }
}
}
