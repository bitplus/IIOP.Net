/* Generated By:JJTree: Do not edit this line. ASTparameter_dcls.cs */

using System;

namespace parser {

public class ASTparameter_dcls : SimpleNode {
  public ASTparameter_dcls(int id) : base(id) {
  }

  public ASTparameter_dcls(IDLParser p, int id) : base(p, id) {
  }


  /** Accept the visitor. **/
  public override Object jjtAccept(IDLParserVisitor visitor, Object data) {
    return visitor.visit(this, data);
  }
  
  public override string GetEmbedderDesc() {
      return ((SimpleNode)jjtGetParent()).GetEmbedderDesc();
  }

  
}


}

