<%@ Page Title="" Language="C#" MasterPageFile="~/DBC.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="AttendanceMonitoringSystem.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style10 {
            width: 149px;
            height: 67px;
        }
        .auto-style12 {
            width: 482px;
            height: 67px;
        }
        .auto-style14 {
            height: 333px;
            width: 498px;
            margin-top: 0px;
        }
        .auto-style16 {
            height: 67px;
            width: 332px;
        }
        .auto-style23 {
            width: 100%;
            height: 26px;
        }
        .auto-style30 {
            width: 38%;
        }
        .auto-style31 {
            width: 121px;
        }
        .auto-style32 {
            width: 65px;
        }
        .auto-style45 {
            width: 507px;
        }
        .auto-style48 {
            width: 533px;
            height: 196px;
        }
        .auto-style49 {
            height: 22px;
        }
        .auto-style50 {
            width: 538px;
            height: 216px;
        }
        .auto-style51 {
            width: 534px;
            height: 219px;
        }
        .auto-style52 {
            width: 183px;
        }
        .auto-style53 {
            width: 137px;
        }
        .auto-style54 {
            width: 100%;
            height: 248px;
        }
        .auto-style55 {
            width: 501px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <table class="auto-style23" style="background-image:url('Pictures/BW.PNG');" >
         <tr>
             <td class="auto-style49" colspan="3">
                <h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; REGISTRATION FORM</h3>
             </td>
         </tr>
         </table>

        <table class="auto-style54">
            <tr>
                <td class="auto-style32">

               </td>

             <td class="auto-style30">
                                   <table class="auto-style48">
                      <tr>
                          <td class="auto-style51">
                               <table class="auto-style50">
                <tr>
                    <td class="auto-style36">
                        <asp:label runat="server" text="Student Name"></asp:label>
                    </td>
                    <td>
                     <table class="auto-style26">
                        <tr>
                            <td class="style26">
                         <asp:TextBox ID="TxtName" runat="server" Width="221px"></asp:TextBox>
                            </td>
                        </tr>
                     </table>   
                    </td>
                    <td>
                    </td>
                </tr>

                         <tr>
                    <td class="auto-style36">
                    <asp:Label ID="LblStudentNo" runat="server" Text="Student Number"></asp:Label>
                    </td>
                    <td class="style17">
                        <asp:TextBox ID="TxtStudentNo" runat="server" Width="226px"></asp:TextBox>
                     </td>
                    <td class="style13">
                    </td>
                </tr>
                  <tr>
                    <td class="auto-style36">
                        Program</td>
                    <td class="style17">
                        <asp:TextBox ID="TxtProgram" runat="server" Width="226px"></asp:TextBox>
                      </td>
                    <td class="style13">
                        <br />
                    </td>
                </tr>
                <tr>
                 <td class="auto-style36">
                    <asp:Label ID="LblYear" runat="server" Text="Year"></asp:Label>
                    </td>
                    <td class="style17">
                        <asp:TextBox ID="TxtYear" runat="server" Width="226px"></asp:TextBox>
                      </td>
                    <td class="style13">
                        <br />
                    </td>
                     </tr>

                       <tr>
                 <td class="auto-style38">
                    <asp:Label ID="lblPosition" runat="server" Text="Position"></asp:Label>
                    </td>
                    <td class="auto-style39">
                        <asp:DropDownList ID="ddlPosition" runat="server" Height="16px" Width="237px"></asp:DropDownList>
                      </td>
                    <td class="auto-style39">
                        <br />
                    </td>
                </tr>

                     <tr>
                 <td class="auto-style36"><asp:Label ID="LblNote" runat="server" BorderStyle="None" />
                     &nbsp;</td>
                    <td class="style17">

                       <table class="auto-style20">
                        <tr>
                            <td class="auto-style22"></td>
                            <td class="auto-style21">
                            <asp:Button ID="btnReg" runat="server" Text="Register" Width="105px" Height="26px" 
                                    style="margin-left: 45px" OnClick="btnReg_Click" />
                            </td>
                            <td class="auto-style19"></td>
                        </tr>
                       </table>

                      </td>
                    <td class="style13">
                        <br />
                    </td>
                </tr>
                </table>     
                          </td>
                      </tr>
                      </table>
              </td>

             <td class="auto-style31">
     
             </td>
            </tr>
        </table>    

         <table style="width:100%">
            <tr>
                <td></td>
                <td class="auto-style55"></td>
                <td></td>
            </tr>
        </table>

           <table>
             <tr>
                <td class="auto-style53"> </td>
           <td class="auto-style45">
               <asp:GridView ID="gvClassRecord" runat="server" CssClass="gv" Width="785px"></asp:GridView>
               </td>
           <td class="auto-style52"></td>
       </tr>
   </table>
</asp:Content>
