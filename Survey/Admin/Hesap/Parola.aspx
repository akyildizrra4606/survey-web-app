﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Parola.aspx.cs" Inherits="Survey.Admin.Hesap.Parola" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="well">
                <div class="form-horizontal">
                    <fieldset>
                        <legend>Parola Değiştir</legend>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Mevcut Parola</label>
                            <div class="col-sm-6">
                                <input id="txtMevcutParola" name="txtMevcutParola" class="form-control" type="password" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Yeni Parola</label>
                            <div class="col-sm-6">
                                <input id="txtYeniParola" name="txtYeniParola" class="form-control" type="password" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Yeni Parola Tekrar</label>
                            <div class="col-sm-6">
                                <input id="txtYeniParolaTek" name="txtYeniParolaTek" class="form-control" type="password" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label"></label>
                            <div class="col-md-6">
                                <asp:Button Text="Vazgeç" ID="btnVazgec" CssClass="btn btn-danger btn-lg" OnClick="btnVazgec_Click" runat="server" />
                                <asp:Button Text="Değiştir" ID="btnDegistir" CssClass="btn btn-success btn-lg" OnClick="btnDegistir_Click" runat="server" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label"></label>
                            <div id="sonuc" class="col-md-6">
                            </div>
                        </div>
                    </fieldset>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
