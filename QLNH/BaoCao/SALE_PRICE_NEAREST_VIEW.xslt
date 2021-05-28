<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output  method="html" indent="yes"/>

    <xsl:template match="@* | node()">
      <HTML>
        <body>

          <table border="0" width="100%">
            <tr>
              <td align="left" width="30%"><b>NHÀ HÀNG SƠN CƯỚC</b></td>
              <td align="center" width="20%"></td>
              <td align="center" width="50%">CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM</td>
            </tr>
            <tr>
              <td align="left">Phiếu số:</td>
              <td align="center"></td>
              <td align="center">Độc Lập - Tự Do - Hạnh Phúc</td>
            </tr>
          </table>
          <p align="center"><b><font size="5">BÁO CÁO DANH SÁCH MÓN ĂN</font></b></p>
          <p></p>
          <table border="1" width="100%" id="table1" style="border-collapse: collapse" bordercolor="#000000">
            <tr>
              <td align="center" width="10%"><b>Mã món</b></td>
              <td align="center" width="40%"><b>Tên món</b></td>
              <td align="center" width="25%"><b>Đơn giá</b></td>
              <td align="center" width="15%"><b>Loại món</b></td>
            </tr>
            <xsl:for-each select="SALE_PRICE_NEAREST_VIEW">
              <tr>
                <td align="left"><xsl:value-of select="ITEM_ID"/></td>
                <td align="left"><xsl:value-of select="ITEM_NAME"/></td>
                <td align="left"><xsl:value-of select="PRICE"/></td>
                <td align="left"><xsl:value-of select="ITEM_CLASS_NAME"/></td>                
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
              <td align="center">(<i>Ký, ghi rõ h tên</i>)</td>
            </tr>
          </table>
        </body>
      </HTML>  
      
    </xsl:template>
</xsl:stylesheet>
