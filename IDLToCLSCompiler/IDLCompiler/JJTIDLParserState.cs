/* Generated By:JJTree: Do not edit this line. JJTIDLParserState.cs */

using System;

namespace parser {

public class JJTIDLParserState {
  private System.Collections.Stack nodes;
  private System.Collections.Stack marks;

  private int sp;		// number of nodes on stack
  private int mk;		// current mark
  private bool node_created;

  internal JJTIDLParserState() {
    nodes = new System.Collections.Stack();
    marks = new System.Collections.Stack();
    sp = 0;
    mk = 0;
  }

  /* Determines whether the current node was actually closed and
     pushed.  This should only be called in the final user action of a
     node scope.  */
  internal bool nodeCreated() {
    return node_created;
  }

  /* Call this to reinitialize the node stack.  It is called
     automatically by the parser's ReInit() method. */
  internal void reset() {
    nodes.Clear();
    marks.Clear();
    sp = 0;
    mk = 0;
  }

  /* Returns the root node of the AST.  It only makes sense to call
     this after a successful parse. */
  internal Node rootNode() {
    return (Node)nodes.Peek();
  }

  /* Pushes a node on to the stack. */
  internal void pushNode(Node n) {
    nodes.Push(n);
    ++sp;
  }

  /* Returns the node on the top of the stack, and remove it from the
     stack.  */
  internal Node popNode() {
    if (--sp < mk) {
      mk = ((System.Int32)marks.Pop());
    }
    return (Node)nodes.Pop();
  }

  /* Returns the node currently on the top of the stack. */
  internal Node peekNode() {
    return (Node)nodes.Peek();
  }

  /* Returns the number of children on the stack in the current node
     scope. */
  internal int nodeArity() {
    return sp - mk;
  }


  internal void clearNodeScope(Node n) {
    while (sp > mk) {
      popNode();
    }
    mk = ((System.Int32)marks.Pop());
  }


  internal void openNodeScope(Node n) {
    marks.Push(mk);
    mk = sp;
    n.jjtOpen();
  }


  /* A definite node is constructed from a specified number of
     children.  That number of nodes are popped from the stack and
     made the children of the definite node.  Then the definite node
     is pushed on to the stack. */
  internal void closeNodeScope(Node n, int num) {
    mk = ((System.Int32)marks.Pop());
    while (num-- > 0) {
      Node c = popNode();
      c.jjtSetParent(n);
      n.jjtAddChild(c, num);
    }
    n.jjtClose();
    pushNode(n);
    node_created = true;
  }


  /* A conditional node is constructed if its condition is true.  All
     the nodes that have been pushed since the node was opened are
     made children of the the conditional node, which is then pushed
     on to the stack.  If the condition is false the node is not
     constructed and they are left on the stack. */
  internal void closeNodeScope(Node n, bool condition) {
    if (condition) {
      int a = nodeArity();
      mk = ((System.Int32)marks.Pop());
      while (a-- > 0) {
	Node c = popNode();
	c.jjtSetParent(n);
	n.jjtAddChild(c, a);
      }
      n.jjtClose();
      pushNode(n);
      node_created = true;
    } else {
      mk = ((System.Int32)marks.Pop());
      node_created = false;
    }
  }
}


}

