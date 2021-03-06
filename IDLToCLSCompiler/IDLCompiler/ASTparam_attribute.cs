/* Generated By:JJTree: Do not edit this line. ASTparam_attribute.cs */

/* ASTparam_attribute.cs
 * 
 * Project: IIOP.NET
 * IDLToCLSCompiler
 * 
 * WHEN      RESPONSIBLE
 * 14.02.03  Dominic Ullmann (DUL), dominic.ullmann -at- elca.ch
 *  
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

using System;
using Ch.Elca.Iiop.IdlCompiler.Exceptions;
using Ch.Elca.Iiop.Idl;

namespace parser {

public class ASTparam_attribute : SimpleNode {

    #region Constants

    public const int ParamDir_IN = 0;
    public const int ParamDir_OUT = 1;
    public const int ParamDir_INOUT = 2;

    #endregion Constants
    #region IFields
    
    private ParameterSpec.ParameterDirection m_paramDir = ParameterSpec.ParameterDirection.s_in;
    
    #endregion IFields
    #region IConstructors

    public ASTparam_attribute(int id) : base(id) {
    }

    public ASTparam_attribute(IDLParser p, int id) : base(p, id) {
    }
    
    #endregion IConstructors
    #region IMethods

    /** Accept the visitor. **/
    public override Object jjtAccept(IDLParserVisitor visitor, Object data) {
        return visitor.visit(this, data);
    }
  
    public void setParamDir(int paramDir) {
        switch (paramDir) {
            case ParamDir_IN:
                m_paramDir = ParameterSpec.ParameterDirection.s_in;
                break;
            case ParamDir_INOUT:
                m_paramDir = ParameterSpec.ParameterDirection.s_inout;
                break;
            case ParamDir_OUT:
                m_paramDir = ParameterSpec.ParameterDirection.s_out;
                break;
            default:
                throw new InternalCompilerException("invalid parameter direction: " + paramDir);
        }
    }

    public ParameterSpec.ParameterDirection getParamDir() {
        return m_paramDir;
    }
    
    #endregion IMethods

}
}
