<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="@* | node()">
      <HTML>
        <body>
          <p align="center">
            <b>
              <font size="5">BÁO CÁO DANH SÁCH NHÂN VIÊN</font>
            </b>
          </p>
          <p align="center">
            <table border="1" width="100%" id="table1" style="border-collapse: collapse" bordercolor="#000000">
              <tr>
                <td align="center">
                  <b>Mã NV</b>
                </td>
                <td align="center">
                  <b>Tên NV</b>
                </td>
                <td align="center">
                  <b>Mã tầng</b>
                </td>
                <td align="center">
                  <b>Điện thoại</b>
                </td>
                <td align="center">
                  <b>Số chứng minh</b>
                </td>
                <td align="center">
                  <b>Mật khẩu</b>
                </td>
              </tr>
              
              <xsl:for-each select="DM_EMPLOYEES">
                <tr>
                  <td align="left">
                    <xsl:for-each select="USER_ID"></xsl:for-each>
                  </td>
                  <td align="left">
                    <xsl:for-each select="USER_NAME"></xsl:for-each>
                  </td>
                  <td align="left">
                    <xsl:for-each select="LEVEL_ID"></xsl:for-each>
                  </td>
                  <td align="left">
                    <xsl:for-each select="PHONE"></xsl:for-each>
                  </td>
                  <td align="left">
                    <xsl:for-each select="PASSPORT"></xsl:for-each>
                  </td>
                  <td align="left">
                    <xsl:for-each select="PASSWORD"></xsl:for-each>
                  </td>
                </tr>
              </xsl:for-each>
            </table>

            <p></p>
            <table border="0" width="100%">
              <tr>
                <td width="30%"></td>
                <td width="30%"></td>
                <td align="center" width="40%">Hà Nội, ngày...tháng...năm....</td>
              </tr>
              <tr>
                <td></td>
                <td></td>
                <td align="center">Người lập phiếu</td>
              </tr>
              <tr>
                <td></td>
                <td></td>
                <td align="center">
                  (<i>Ký, ghi rõ h tên</i>)
                </td>
              </tr>
            </table>
          </p>
        </body>
      </HTML>
    </xsl:template>
</xsl:stylesheet>
