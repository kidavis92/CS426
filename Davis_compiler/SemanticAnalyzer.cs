using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davis_compiler
{
    class SemanticAnalyzer : comp5210.analysis.DepthFirstAdapter
    {
        System.Collections.Generic.Dictionary<string, Davis_compiler.Definition>
            stringhash = new Dictionary<string, Definition>();
        System.Collections.Generic.Dictionary<comp5210.node.Node, Davis_compiler.Definition>
            nodehash = new Dictionary<comp5210.node.Node, Definition>();

        // before theclass starts, create the two hashes and 
        // add int and float
        public override void InAProgram(comp5210.node.AProgram node)
        {
            BasicType inttype = new BasicType();
            inttype.name = "int";
            BasicType flttype = new BasicType();
            flttype.name = "float";
            BasicType strtype = new BasicType();
            strtype.name = "string";
            stringhash.Add(inttype.name, inttype);
            stringhash.Add(flttype.name, flttype);
            stringhash.Add(strtype.name, strtype);
        }

        // override the case to change the order, this way processes them
        // backwards (for no good reason)
        //        public override void CaseAMoreDecls(comp5210.node.AM node)
        //        {
        //            InAMoreDecls(node);
        //            if (node.GetDecl() != null)
        //            {
        //                node.GetDecl().Apply(this);
        //           }
        //            if (node.GetDecls() != null)
        //            {
        //                node.GetDecls().Apply(this);
        //            }
        //            OutAMoreDecls(node);
        //        }

        // begin our work
        public override void OutAProgram(comp5210.node.AProgram node)
        {
        }
        public override void OutAIntegerConstants(comp5210.node.AIntegerConstants node)
        {

        }
        public override void OutAFloatConstants(comp5210.node.AFloatConstants node)
        {

        }
        public override void OutAStringConstants(comp5210.node.AStringConstants node)
        {

        }
        public override void OutANoneConstants(comp5210.node.ANoneConstants node)
        {

        }
        public override void OutAMainProgram(comp5210.node.AMainProgram node)
        {
        }

        public override void OutAFormalParam(comp5210.node.AFormalParam node)
        {
            base.OutAFormalParam(node);
        }
        public override void OutANoneFormalParam(comp5210.node.ANoneFormalParam node)
        {
            base.OutANoneFormalParam(node);
        }
        public override void OutANoneformalparam(comp5210.node.ANoneFormalParam node)
        {
        }
        //fix
        public override void OutATypeSecondParam(comp5210.node.ATypeSecondParam node)
        {
        }
        public override void OutANoneSecondParam(comp5210.node.ANoneSecondParam node)
        {
        }
        //end fix
        public override void OutAIfsStuff(comp5210.node.AIfsStuff node)
        {
        }
        public override void OutAWhilesStuff(comp5210.node.AWhilesStuff node)
        {
        }
        public override void OutAMethodsStuff(comp5210.node.AMethodsStuff node)
        {
        }
        public override void OutADeclsStuff(comp5210.node.ADeclsStuff node)
        {
        }
        public override void OutAAssignsStuff(comp5210.node.AAssignsStuff node)
        {
        }
        public override void OutANoneStuff(comp5210.node.ANoneStuff node)
        {
        }
        public override void OutARecursiveDeclarations(comp5210.node.ARecursiveDeclarations node)
        {
        }
        public override void OutANotDeclarations(comp5210.node.ANotDeclarations node)
        {
        }
        public override void OutASide1Declaration(comp5210.node.ASide1Declaration node)
        {
        }
        public override void OutASide2Declaration(comp5210.node.ASide2Declaration node)
        {
        }
        public override void OutARecursiveAssignments(comp5210.node.ARecursiveAssignments node)
        {
        }
        public override void OutANotAssignments(comp5210.node.ANotAssignments node)
        {
        }
        public override void OutAIntAssign(comp5210.node.AIntAssign node)
        {
        }
        public override void OutAFloatAssign(comp5210.node.AFloatAssign node)
        {
        }
        public override void OutAStringAssign(comp5210.node.AStringAssign node)
        {
        }
        public override void OutAIfState(comp5210.node.AIfState node)
        {
        }
        public override void OutAWhileState(comp5210.node.AWhileState node)
        {
            base.OutAWhileState(node);
        }

        // end our work


        // 
        //        public override void OutADecl(comp5210.node.ADecl node)
        //        {
        //            string typename = node.GetTypename().Text;
        //            string varname = node.GetVarname().Text;
        //            Definition typedefn;
        //            // lookup the type
        //            if (!stringhash.TryGetValue(typename, out typedefn))
        //            {
        //                Console.WriteLine("[" + node.GetTypename().Line + "]: " +
        //                    typename + " is not defined.");
        //           }
        // check to make sure what we got back is a type
        //            else if (!(typedefn is TypeDefinition))
        //            {
        //                Console.WriteLine("[" + node.GetSemicolon().Line + "]: " +
        //                    typename + " is an invalid type.");
        //           }
        //            else
        //            {
        // add this variable to the hash table
        // note you need to add checks to make sure this 
        // variable name isn't already defined look it up in the sringhash.
        //               VariableDefinition vardefn = new VariableDefinition();
        //               vardefn.name = varname;
        //               vardefn.vartype = typedefn as TypeDefinition;
        //                stringhash.Add(vardefn.name, vardefn);
        //           }
        //       }
        //        public override void OutAStmt(comp5210.node.AStmt node)
        //       {
        //           Definition rhs, lhs;
        //           nodehash.TryGetValue(node.GetExpr(), out rhs);
        //           stringhash.TryGetValue(node.GetId().Text, out lhs);
        //           // make sure left hand side and right hand side match
        //           // of course, you should really make sure left side is
        //           // a variable first make sure lhs is a variable definition
        //            if ((lhs as VariableDefinition).vartype != rhs)
        //            {
        //                Console.WriteLine("[" + node.GetEquals().Line + "]: " +
        //                    "types don't match");
        //            }
        //        }
        //        public override void OutAComplexExpr(comp5210.node.AComplexExpr node)
        //       {
        //           Definition lhs;
        //           nodehash.TryGetValue(node.GetBase(), out lhs);
        // you should really get the types of both sides and make sure 
        // they match
        // make sure the type of the child is a BasicType, as those
        // are the only addable things.
        //           nodehash.Add(node, lhs);
        //       }
        //       public override void OutASimpleExpr(comp5210.node.ASimpleExpr node)
        //       {
        //          Definition lhs;
        //           nodehash.TryGetValue(node.GetBase(), out lhs);
        //           nodehash.Add(node, lhs);
        //        }
        //        public override void OutAParenBase(comp5210.node.AParenBase node)
        //        {
        //            Definition exprdefn;
        //           nodehash.TryGetValue(node.GetExpr(), out exprdefn);
        //           nodehash.Add(node, exprdefn);
        //        }
        //        public override void OutAIdBase(comp5210.node.AIdBase node)
        //       {
        //           Definition iddefn;
        //           if (!stringhash.TryGetValue(node.GetId().Text, out iddefn))
        //          {
        //                Console.WriteLine("[" + node.GetId().Line + "]: " +
        //                   node.GetId().Text + " is not defined");
        //           }
        // you should really make sure that iddefn is a variable 
        // definition
        //            else
        //            {
        //                nodehash.Add(node, (iddefn as VariableDefinition).vartype);
        //            }
        //        }
        //        public override void OutAOthersMoreParam(comp5210.node.AOthersMorePa node)
        //        {

        //           string varname = node.GetVar().Text;
        //            Definition typedefn;
        // lookup the type
        //            if (!stringhash.TryGetValue(typename, out typedefn))
        //            {
        //               Console.WriteLine("[" + node.GetTypename().Line + "]: " +
        //                    typename + " is not defined.");
        //           }
        // check to make sure what we got back is a type
        //            else if (!(typedefn is TypeDefinition))
        //            {
        //                Console.WriteLine("[" + node.GetSemicolon().Line + "]: " +
        //                   typename + " is an invalid type.");
        //           }
        //           else
        //           {
        // add this variable to the hash table
        // note you need to add checks to make sure this 
        // variable name isn't already defined look it up in the sringhash.
        //                VariableDefinition vardefn = new VariableDefinition();
        //                vardefn.name = varname;
        //               vardefn.vartype = typedefn as TypeDefinition;
        //               stringhash.Add(vardefn.name, vardefn);
        //           }
        //       }
        //   }
    }
}
