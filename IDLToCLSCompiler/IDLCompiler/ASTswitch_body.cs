/* Generated By:JJTree: Do not edit this line. ASTswitch_body.cs */

using System;

namespace parser {

public class ASTswitch_body : SimpleNode {
  public ASTswitch_body(int id) : base(id) {
  }

  public ASTswitch_body(IDLParser p, int id) : base(p, id) {
  }


  /** Accept the visitor. **/
  public override Object jjtAccept(IDLParserVisitor visitor, Object data) {
    return visitor.visit(this, data);
  }
  
  public override string GetIdentification() {
      return "switch body in " + ((SimpleNode)jjtGetParent()).GetEmbedderDesc();
  }
  
  public override string GetEmbedderDesc() {
      return ((SimpleNode)jjtGetParent()).GetEmbedderDesc();
  }
  
}


}

