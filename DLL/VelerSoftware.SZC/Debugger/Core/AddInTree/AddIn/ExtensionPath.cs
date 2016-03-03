﻿// *****************************************************************************
// 
//  © Veler Software 2012. All rights reserved.
//  The current code and the associated software are the proprietary 
//  information of Etienne Baudoux from Veler Software and are
//  supplied subject to licence terms.
// 
//  www.velersoftware.com
// *****************************************************************************




using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace VelerSoftware.SZC.Debugger.Core
{
    /// <summary>
    /// Represents all contributions to a Path in a single .addin file.
    /// </summary>
    public class ExtensionPath
    {
        string name;
        AddIn addIn;
        List<List<Codon>> codons = new List<List<Codon>>();

        public AddIn AddIn
        {
            get
            {
                return addIn;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public IEnumerable<Codon> Codons
        {
            get
            {
                return
                    from list in codons
                    from c in list
                    select c;
            }
        }

        /// <summary>
        /// Gets the codons separated by the groups they were created in.
        /// i.e. if two addins add the codons to the same path they will be in diffrent group.
        /// if the same addin adds the codon in diffrent path elements they will be in diffrent groups.
        /// </summary>
        public IEnumerable<IEnumerable<Codon>> GroupedCodons
        {
            get
            {
                return codons.AsReadOnly();
            }
        }

        public ExtensionPath(string name, AddIn addIn)
        {
            this.addIn = addIn;
            this.name = name;
        }

        public static void SetUp(ExtensionPath extensionPath, XmlReader reader, string endElement)
        {
            Stack<ICondition> conditionStack = new Stack<ICondition>();
            List<Codon> innerCodons = new List<Codon>();
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.EndElement:
                        if (reader.LocalName == "Condition" || reader.LocalName == "ComplexCondition")
                        {
                            conditionStack.Pop();
                        }
                        else if (reader.LocalName == endElement)
                        {
                            if (innerCodons.Count > 0)
                                extensionPath.codons.Add(innerCodons);
                            return;
                        }
                        break;
                    case XmlNodeType.Element:
                        string elementName = reader.LocalName;
                        if (elementName == "Condition")
                        {
                            conditionStack.Push(Condition.Read(reader));
                        }
                        else if (elementName == "ComplexCondition")
                        {
                            conditionStack.Push(Condition.ReadComplexCondition(reader));
                        }
                        else
                        {
                            Codon newCodon = new Codon(extensionPath.AddIn, elementName, Properties.ReadFromAttributes(reader), conditionStack.ToArray());
                            innerCodons.Add(newCodon);
                            if (!reader.IsEmptyElement)
                            {
                                ExtensionPath subPath = extensionPath.AddIn.GetExtensionPath(extensionPath.Name + "/" + newCodon.Id);
                                //foreach (ICondition condition in extensionPath.conditionStack) {
                                //	subPath.conditionStack.Push(condition);
                                //}
                                SetUp(subPath, reader, elementName);
                                //foreach (ICondition condition in extensionPath.conditionStack) {
                                //	subPath.conditionStack.Pop();
                                //}
                            }
                        }
                        break;
                }
            }
            if (innerCodons.Count > 0)
                extensionPath.codons.Add(innerCodons);
        }
    }
}