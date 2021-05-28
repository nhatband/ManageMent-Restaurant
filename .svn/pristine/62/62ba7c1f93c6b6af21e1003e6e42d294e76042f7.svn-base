<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
    <xsl:output method="html" indent="yes"/>
    <xsl:template match="@* | node()">
      <HTML>
        <body>
          <p align="center"><b><font size="5">BÁO CÁO DANH MỤC NHÀ CUNG CẤP</font></b></p>
          <p align="center">
            <table border="1" width="100%" id="table1" style="border-collapse: collapse" bordercolor="#000000">
              <tr>
                <td align="center"><b>Mã NCC</b></td>
                <td align="center"><b>Tên NCC</b></td>
                <td align="center"><b>Người liên hệ</b></td>
                <td align="center"><b>Điện thoại</b></td>
                <td align="center"><b>Địa chỉ</b></td>
                <td align="center"><b>Email</b></td>
              </tr>
              <xsl:for-each select="DM_PROVIDERS">
                <tr>
                  <td align="left"><xsl:value-of select="PROVIDER_ID"/></td>
                  <td align="left"><xsl:value-of select="PROVIDER_NAME"/></td>
                  <td align="left"><xsl:value-of select="CONTACT_PERSON"/></td>
                  <td align="left"><xsl:value-of select="PHONE"/></td>
                  <td align="left"><xsl:value-of select="ADDRESS"/></td>
                  <td align="left"><xsl:value-of select="EMAIL"/></td>
                </tr>
             </xsl:for-each>
            </table>
          </p>
          <p align="left"></p>
        </body>
      </HTML>
    </xsl:template>
</xsl:stylesheet>
