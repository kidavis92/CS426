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
            BoolType booltype = new BoolType();
            booltype.name = "boolean";
            stringhash.Add(inttype.name, inttype);
            stringhash.Add(flttype.name, flttype);
            stringhash.Add(booltype.name, booltype);
        }

        public override void OutARecursStatements(comp5210.node.ARecursStatements node)
        {
            base.OutARecursStatements(node);
        }
        public override void OutAOneStatements(comp5210.node.AOneStatements node)
        {
            base.OutAOneStatements(node);
        }
        public override void OutAIfsStatement(comp5210.node.AIfsStatement node)
        {
            base.OutAIfsStatement(node);
        }
        public override void OutAMethStatement(comp5210.node.AMethStatement node)
        {
            base.OutAMethStatement(node);
        }
        public override void OutAWhilesStatement(comp5210.node.AWhilesStatement node)
        {
            base.OutAWhilesStatement(node);
        }
        public override void OutADeclStatement(comp5210.node.ADeclStatement node)
        {
            base.OutADeclStatement(node);
        }
        public override void OutAAssStatement(comp5210.node.AAssStatement node)
        {
            base.OutAAssStatement(node);
        }
        public override void OutAIfsIfState(comp5210.node.AIfsIfState node)
        {
            base.OutAIfsIfState(node);
        }
        public override void OutAElsesIfState(comp5210.node.AElsesIfState node)
        {
            base.OutAElsesIfState(node);
        }
        public override void OutAWhileState(comp5210.node.AWhileState node)
        {
            base.OutAWhileState(node);
        }
        public override void OutAParamsMethodsCall(comp5210.node.AParamsMethodsCall node)
        {
            base.OutAParamsMethodsCall(node);
        }
        public override void OutANoparamsMethodsCall(comp5210.node.ANoparamsMethodsCall node)
        {
            base.OutANoparamsMethodsCall(node);
        }
        public override void OutARecurActualParams(comp5210.node.ARecurActualParams node)
        {
            base.OutARecurActualParams(node);
        }
        public override void OutAOneActualParams(comp5210.node.AOneActualParams node)
        {
            base.OutAOneActualParams(node);
        }
        public override void OutAExpressionsActualConsts(comp5210.node.AExpressionsActualConsts node)
        {
            base.OutAExpressionsActualConsts(node);
        }
        public override void OutAStringsActualConsts(comp5210.node.AStringsActualConsts node)
        {
            base.OutAStringsActualConsts(node);
        }
        public override void OutARecurseMethDecs(comp5210.node.ARecurseMethDecs node)
        {
            base.OutARecurseMethDecs(node);
        }
        public override void OutAOneMethDecs(comp5210.node.AOneMethDecs node)
        {
            base.OutAOneMethDecs(node);
        }
        public override void OutAParamsMethodsDecl(comp5210.node.AParamsMethodsDecl node)
        {
            base.OutAParamsMethodsDecl(node);
        }
        public override void OutANoparamsMethodsDecl(comp5210.node.ANoparamsMethodsDecl node)
        {
            base.OutANoparamsMethodsDecl(node);
        }
        public override void OutAMainMethodsDecl(comp5210.node.AMainMethodsDecl node)
        {

        }
        public override void OutAEmptyparaMethodsDecl(comp5210.node.AEmptyparaMethodsDecl node)
        {
            base.OutAEmptyparaMethodsDecl(node);
        }
        public override void OutAEmptynoparaMethodsDecl(comp5210.node.AEmptynoparaMethodsDecl node)
        {
            base.OutAEmptynoparaMethodsDecl(node);
        }
        public override void OutAEmptymainMethodsDecl(comp5210.node.AEmptymainMethodsDecl node)
        {
            base.OutAEmptymainMethodsDecl(node);
        }
        public override void OutARecurFormalParams(comp5210.node.ARecurFormalParams node)
        {
            base.OutARecurFormalParams(node);
        }
        public override void OutAOneFormalParams(comp5210.node.AOneFormalParams node)
        {
            base.OutAOneFormalParams(node);
        }
        public override void OutAVarsFormalConsts(comp5210.node.AVarsFormalConsts node)
        {
            base.OutAVarsFormalConsts(node);
        }
        public override void OutAArrFormalConsts(comp5210.node.AArrFormalConsts node)
        {
            base.OutAArrFormalConsts(node);
        }
        public override void OutAOrExpressLogic(comp5210.node.AOrExpressLogic node)
        {
            base.OutAOrExpressLogic(node);
        }
        public override void OutAAndExpressLogic(comp5210.node.AAndExpressLogic node)
        {
            base.OutAAndExpressLogic(node);
        }
        public override void OutANotExpressLogic(comp5210.node.ANotExpressLogic node)
        {
            base.OutANotExpressLogic(node);
        }
        public override void OutACompExpressLogic(comp5210.node.ACompExpressLogic node)
        {
            base.OutACompExpressLogic(node);
        }
        public override void OutAGteExpressComp(comp5210.node.AGteExpressComp node)
        {
            base.OutAGteExpressComp(node);
        }
        public override void OutALteExpressComp(comp5210.node.ALteExpressComp node)
        {
            base.OutALteExpressComp(node);
        }
        public override void OutALtExpressComp(comp5210.node.ALtExpressComp node)
        {
            base.OutALtExpressComp(node);
        }
        public override void OutAGtExpressComp(comp5210.node.AGtExpressComp node)
        {
            base.OutAGtExpressComp(node);
        }
        public override void OutAEqsExpressComp(comp5210.node.AEqsExpressComp node)
        {
            Definition lhs, rhs;
            nodehash.TryGetValue(node.GetExpressMd(), out lhs);
            nodehash.TryGetValue(node.GetExpressParent(), out rhs);
            if (!(lhs is BasicType))
            {
                Console.WriteLine("[" + node.GetDivide().Line + "]: " +
                    lhs + " is not a basic type.");
            }
            else if (!(rhs is BasicType))
            {
                Console.WriteLine("[" + node.GetDivide().Line + "]: " +
                    rhs + " is not a basic type.");
            }
            else if (lhs != rhs)
            {
                Console.WriteLine("[" + node.GetDivide().Line + "]: " +
                    lhs + rhs + " are not the same type.");
            }

            Definition boo;
            stringhash.TryGetValue("boolean", out boo);
            nodehash.Add(node, boo);
        }
        public override void OutANoteqsExpressComp(comp5210.node.ANoteqsExpressComp node)
        {
            base.OutANoteqsExpressComp(node);
        }
        public override void OutAMathExpressComp(comp5210.node.AMathExpressComp node)
        {
            base.OutAMathExpressComp(node);
        }
        public override void OutAAddExpressAs(comp5210.node.AAddExpressAs node)
        {
            base.OutAAddExpressAs(node);
        }
        public override void OutASubExpressAs(comp5210.node.ASubExpressAs node)
        {
            base.OutASubExpressAs(node);
        }
        public override void OutAMdExpressAs(comp5210.node.AMdExpressAs node)
        {
            base.OutAMdExpressAs(node);
        }
        public override void OutAMultExpressMd(comp5210.node.AMultExpressMd node)
        {
            Definition lhs, rhs;
            nodehash.TryGetValue(node.GetExpressMd(), out lhs);
            nodehash.TryGetValue(node.GetExpressParent(), out rhs);
            if (!(lhs is BasicType))
            {
                Console.WriteLine("[" + node.GetTimes().Line + "]: " +
                    lhs + " is not a basic type.");
            }
            else if (!(rhs is BasicType))
            {
                Console.WriteLine("[" + node.GetTimes().Line + "]: " +
                    rhs + " is not a basic type.");
            }
            else if (lhs != rhs)
            {
                Console.WriteLine("[" + node.GetTimes().Line + "]: " +
                    lhs + rhs + " are not the same type.");
            }

            nodehash.Add(node, rhs);
        }
        public override void OutADivExpressMd(comp5210.node.ADivExpressMd node)
        {
            Definition lhs, rhs;
            nodehash.TryGetValue(node.GetExpressMd(), out lhs);
            nodehash.TryGetValue(node.GetExpressParent(), out rhs);
            if (!(lhs is BasicType))
            {
                Console.WriteLine("[" + node.GetDivide().Line + "]: " +
                    lhs + " is not a basic type.");
            }
            else if (!(rhs is BasicType))
            {
                Console.WriteLine("[" + node.GetDivide().Line + "]: " +
                    rhs + " is not a basic type.");
            }
            else if (lhs != rhs)
            {
                Console.WriteLine("[" + node.GetDivide().Line + "]: " +
                    lhs + rhs + " are not the same type.");
            }

            nodehash.Add(node, rhs);
        }

        public override void OutAParentExpressMd(comp5210.node.AParentExpressMd node)
        {
            Definition expr;
            nodehash.TryGetValue(node.GetExpressParent(), out expr);
            nodehash.Add(node, expr);
        }
        public override void OutAParentExpressParent(comp5210.node.AParentExpressParent node)
        {
            Definition expr;
            nodehash.TryGetValue(node.GetExpressLogic(), out expr);
            nodehash.Add(node, expr);
        }
        public override void OutAConstsExpressParent(comp5210.node.AConstsExpressParent node)
        {
            Definition expr;
            nodehash.TryGetValue(node.GetExpressConsts(), out expr);
            nodehash.Add(node, expr);
        }

        //Lookup variable, add to Node Hash
        public override void OutANegvarExpressConsts(comp5210.node.ANegvarExpressConsts node)
        {
            //Lookup the variable
            Definition defn;
            stringhash.TryGetValue(node.GetVarNames().Text, out defn);
            if (!stringhash.TryGetValue(node.GetVarNames().Text, out defn))
            {
                Console.WriteLine("[" + node.GetVarNames().Line + "]: " +
                     node.GetVarNames().Text + " is not defined.");
            }
            // check to make sure what we got back is a variable definition
            else if (!(defn is VariableDefinition))
            {
                Console.WriteLine("[" + node.GetVarNames().Line + "]: " +
                   node.GetVarNames().Text + " is an invalid variable.");
            }
            else
            {
                // add this variable to the hash table
                // note you need to add checks to make sure this 
                // variable name isn't already defined look it up in the sringhash.
                if (!stringhash.ContainsKey(node.GetVarNames().Text))
                {
                    nodehash.Add(node, (defn as VariableDefinition).vartype);
                }
                else
                {
                    Console.WriteLine("[" + node.GetVarNames().Line + "]: " +
                     node.GetVarNames().Text + " is already defined.");
                }          
            }
            
        }
        //Lookup, Type Check, add to Node Hash
        public override void OutANegintExpressConsts(comp5210.node.ANegintExpressConsts node)
        {
            Definition defn;

            //Lookup the Type

            if (!stringhash.TryGetValue("int", out defn))
            {
                Console.WriteLine("[" + node.GetType().Name + "]: " +
                     node.GetType().Name + " is not defined.");
            }
            else
            {
                // add this variable to the hash table

                    nodehash.Add(node, (defn as Definition));

                         
            }
            
          
        }
        public override void OutANegfloExpressConsts(comp5210.node.ANegfloExpressConsts node)
        {
            Definition defn;

            //Lookup the Type

            if (!stringhash.TryGetValue("float", out defn))
            {
                Console.WriteLine("[" + node.GetType().Name + "]: " +
                     node.GetType().Name + " is not defined.");
            }
            else
            {
                // add this variable to the hash table

                    nodehash.Add(node, (defn as Definition));
 
                         
            }
        }
        public override void OutAVarExpressConsts(comp5210.node.AVarExpressConsts node)
        {
            //Lookup the variable
            Definition defn;
            stringhash.TryGetValue(node.GetVarNames().Text, out defn);
            if (!stringhash.TryGetValue(node.GetVarNames().Text, out defn))
            {
                Console.WriteLine("[" + node.GetVarNames().Line + "]: " +
                     node.GetVarNames().Text + " is not defined.");
            }
            // check to make sure what we got back is a variable definition
            else if (!(defn is VariableDefinition))
            {
                Console.WriteLine("[" + node.GetVarNames().Line + "]: " +
                   node.GetVarNames().Text + " is an invalid variable.");
            }
            else
            {
                // add this variable to the hash table
                // note you need to add checks to make sure this 
                // variable name isn't already defined look it up in the sringhash.
                if (!stringhash.ContainsKey(node.GetVarNames().Text))
                {
                    nodehash.Add(node, (defn as VariableDefinition).vartype);
                }
                else
                {
                    Console.WriteLine("[" + node.GetVarNames().Line + "]: " +
                     node.GetVarNames().Text + " is already defined.");
                }
            }
        }
        public override void OutAIntsExpressConsts(comp5210.node.AIntsExpressConsts node)
        {
            Definition defn;

            //Lookup the Type

            if (!stringhash.TryGetValue("int", out defn))
            {
                Console.WriteLine("[" + node.GetType().Name + "]: " +
                     node.GetType().Name + " is not defined.");
            }
            else
            {
                // add this variable to the hash table

                    nodehash.Add(node, (defn as Definition));

                         
            }
        }
        public override void OutAFloExpressConsts(comp5210.node.AFloExpressConsts node)
        {
            Definition defn;

            //Lookup the Type

            if (!stringhash.TryGetValue("float", out defn))
            {
                Console.WriteLine("[" + node.GetType().Name + "]: " +
                     node.GetType().Name + " is not defined.");
            }
            else
            {
                // add this variable to the hash table

                    nodehash.Add(node, (defn as Definition));
  
                         
            }
        }
        public override void OutAArrayExpressConsts(comp5210.node.AArrayExpressConsts node)
        {
            base.OutAArrayExpressConsts(node);
        }
        public override void OutADeclarationsDeclarations(comp5210.node.ADeclarationsDeclarations node)
        {
            base.OutADeclarationsDeclarations(node);
        }
        public override void OutADeclarationDeclarations(comp5210.node.ADeclarationDeclarations node)
        {
            base.OutADeclarationDeclarations(node);
        }
        public override void OutAConstantsDeclaration(comp5210.node.AConstantsDeclaration node)
        {
            
        }
        public override void OutAVarsDeclaration(comp5210.node.AVarsDeclaration node)
        {
            
        }
        public override void OutAVarDeclOptions(comp5210.node.AVarDeclOptions node)
        {
            Definition defn;
          
            if (!stringhash.TryGetValue(node.GetVar().Text, out defn))
            {
                Console.WriteLine("[" + node.GetVar().Text + "]: " +
                    node.GetVar().Text + " is not defined.");
            }
            // check to make sure what we got back is a type
            else if (!(defn is VariableDefinition))
            {
                Console.WriteLine("[" + node.GetVar() + "]: " +
                   node.GetVar().Text + " is an invalid variable.");
            }
            else
            {
                // add this variable to the hash table
                // note you need to add checks to make sure this 
                // variable name isn't already defined.
                if (!stringhash.ContainsKey(node.GetVar().Text))
                {
                    nodehash.Add(node, (defn as VariableDefinition).vartype);
                }
                else
                {
                    Console.WriteLine("[" + node.GetVar().Text + "]: " +
                     node.GetVar().Text + " is already defined.");
                }                 
            }
        }
        public override void OutAArrDeclOptions(comp5210.node.AArrDeclOptions node)
        {
            base.OutAArrDeclOptions(node);
        }
        public override void OutAConstantine(comp5210.node.AConstantine node)
        {
            Definition lhs, var, expr;
            // lhs = get id1 text ("int" or something)
            // rhs = get type from nodehash w/ NumConst
            //Get the rhs from the node tree
            nodehash.TryGetValue(node.GetNumConsts(), out expr);

            //Get the lhs (type)
            if (!stringhash.TryGetValue(node.GetId1().Text, out lhs))
            {
                Console.WriteLine("[" + node.GetId1().Text + node.GetId2().Text + "]: " +
                    node.GetId1().Text + node.GetId2().Text + " is not defined.");
            }
            else if (!(lhs is TypeDefinition)) //Make sure lhs is a Variable
            {
                Console.WriteLine("[" + node.GetAssignments().Line + "]: " +
                   node.GetId2() + " is an invalid Variable.");
            }
            else
            {
                // add this variable to the hash table
                // note you need to add checks to make sure this 
                // variable name isn't already defined.
                if (!stringhash.ContainsKey(node.GetId2().Text))
                {
                    if (lhs == expr)
                    {
                        nodehash.Add(node, (lhs));
                    }
                    else
                    {
                        Console.WriteLine("[" + node.GetId2().Line + "]: " +
                        lhs + " is a different type from " + expr);
                        nodehash.Add(node, (lhs));
                    }
                }
                else
                {
                    Console.WriteLine("[" + node.GetId2().Text + "]: " +
                    node.GetId2().Text + " is already defined.");
                    nodehash.Add(node, (lhs));
                }
            }
        }
        public override void OutAPosintNumConsts(comp5210.node.APosintNumConsts node)
        {
            Definition defn;

            if (!stringhash.TryGetValue("int", out defn))
            {
                Console.WriteLine("[" + node.GetType().Name + "]: " +
                     node.GetType().Name + " is not defined.");
            }
            // check to make sure what we got back is a type
            else if (!(defn is TypeDefinition))
            {
                Console.WriteLine("[" + node.GetType() + "]: " +
                   node.GetType().Name + " is an invalid type.");
            }
            else
            {
                // add this type to the hash table

                nodehash.Add(node, (defn as TypeDefinition));
            }
        }
        public override void OutANegintNumConsts(comp5210.node.ANegintNumConsts node)
        {
            Definition defn;

            if (!stringhash.TryGetValue("int", out defn))
            {
                Console.WriteLine("[" + node.GetType().Name + "]: " +
                     node.GetType().Name + " is not defined.");
            }
            // check to make sure what we got back is a type
            else if (!(defn is TypeDefinition))
            {
                Console.WriteLine("[" + node.GetType() + "]: " +
                   node.GetType().Name + " is an invalid type.");
            }
            else
            {
                // add this variable to the hash table

                    nodehash.Add(node, (defn as TypeDefinition));

            }
        }
        public override void OutAPosfloNumConsts(comp5210.node.APosfloNumConsts node)
        {
            Definition defn;

            if (!stringhash.TryGetValue("float", out defn))
            {
                Console.WriteLine("[" + node.GetType().Name + "]: " +
                     node.GetType().Name + " is not defined.");
            }
            // check to make sure what we got back is a type
            else if (!(defn is TypeDefinition))
            {
                Console.WriteLine("[" + node.GetType() + "]: " +
                   node.GetType().Name + " is an invalid type.");
            }
            else
            {
                // add this variable to the hash table

                    nodehash.Add(node, (defn as TypeDefinition));

            }
        }
        public override void OutANegfloNumConsts(comp5210.node.ANegfloNumConsts node)
        {
            Definition defn;

            if (!stringhash.TryGetValue("float", out defn))
            {
                Console.WriteLine("[" + node.GetType().Name + "]: " +
                     node.GetType().Name + " is not defined.");
            }
            // check to make sure what we got back is a type
            else if (!(defn is TypeDefinition))
            {
                Console.WriteLine("[" + node.GetType() + "]: " +
                   node.GetType().Name + " is an invalid type.");
            }
            else
            {
                // add this variable to the hash table

                    nodehash.Add(node, (defn as TypeDefinition));

            }
        }
        public override void OutAVarAssign(comp5210.node.AVarAssign node)
        {
            Definition rhs,lhs;
            
            //Get the rhs from the node tree
            nodehash.TryGetValue(node.GetVarNames(), out rhs);
            
            //Get the lhs (variable)
            if (!stringhash.TryGetValue(node.GetVarNames().Text, out lhs))
            {
                Console.WriteLine("[" + node.GetVarNames().Text + "]: " +
                    node.GetVarNames().Text + " is not defined.");
            }
            else if(!(lhs is VariableDefinition)) //Make sure lhs is a Variable
            {
                Console.WriteLine("[" + node.GetVarNames().Text + "]: " +
                   node.GetVarNames().Text + " is an invalid Variable.");
            }
           
            // make sure left hand side and right hand side match
            if ((lhs as VariableDefinition).vartype != rhs)
            {
                Console.WriteLine("[" + node + "]: " +
                    "types don't match");
            }

        }
        public override void OutAArrAssign(comp5210.node.AArrAssign node)
        {
            base.OutAArrAssign(node);
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
