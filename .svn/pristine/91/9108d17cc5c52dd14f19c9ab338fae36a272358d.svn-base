<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="@* | node()">
      <HTML>
        <body>

          <table border="0" width="100%">
            <tr>
              <td align="left" width="30%">
                <b>NHÀ HÀNG SƠN CƯỚC</b>
              </td>
              <td align="center" width="20%"></td>
              <td align="center" width="50%">CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM</td>
            </tr>
            <tr>
              <td align="left">Phiếu số:</td>
              <td align="center"></td>
              <td align="center">Độc Lập - Tự Do - Hạnh Phúc</td>
            </tr>
          </table>
          <p align="center">
            <b>
              <font size="5">BÁO CÁO BÁN HÀNG THEO HÓA ĐƠN,CHỨNG TỪ</font>
            </b>
          </p>
          <p></p>
          <table border="1" width="100%" id="table1" style="border-collapse: collapse" bordercolor="#000000">
            <tr>
              <td align="center" width="15%">
                <b>Tên KH</b>
              </td>
              <td align="center" width="15%">
                <b>Tên NV</b>
              </td>
              <td align="center" width="150%">
                <b>Tên Bàn</b>
              </td>
              <td align="center" width="10%">
                <b>Loại tiền thanh toán</b>
              </td>
              <td align="center" width="10%">
                <b> Thành tiền</b>
              </td>
              <td align="center" width="10%">
                <b>Khách thanh toán</b>
              </td>
              <td align="center" width="10%">
                <b>Tên Món ăn</b>
              </td>
              <td align="center" width="10%">
                <b>Thuế</b>
              </td>
            </tr>
            <xsl:for-each select="TRAN_NO">
              <tr>
                <td align="left">
                  <xsl:for-each select="CUSTOMER_NAME"></xsl:for-each>
                </td>
                <td align="left">
                  <xsl:for-each select="USER_NAME"></xsl:for-each>
                </td>
                <td align="left">
                  <xsl:for-each select="TABLE_NAME"></xsl:for-each>
                </td>
                <td align="left">
                  <xsl:for-each select="PAY_TYPE_NAME"></xsl:for-each>
                </td>
                <td align="left">
                  <xsl:for-each select="TOTAL_PRICE"></xsl:for-each>
                </td>
                <td align="left">
                  <xsl:for-each select="TOTAL_CUSTOMER_PAY"></xsl:for-each>
                </td>
                <td align="left">
                  <xsl:for-each select="ITEM_NAME"></xsl:for-each>
                </td>
                <td align="left">
                  <xsl:for-each select="VAT_TAX_NAME"></xsl:for-each>
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
        </body>
      </HTML>
    </xsl:template>
</xsl:stylesheet>
