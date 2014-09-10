<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
      <html>
        <body>
          <h1>Students</h1>
          <table>
            <tr bgcolor ="#EEEEEE">
              <td>
                <b>Name
                </b>
              </td>
              <td>
                <b>Sex</b>
              </td>
              <td>
                <b>Birth Date</b>
              </td>
            </tr>
            <xsl:for-each select="/students/student">
              <tr>
                <td>
                  <xsl:value-of select="name"/>
                </td>
                <td>
                  <xsl:value-of select="sex"/>
                </td>
                <td>
                  <xsl:value-of select="birth-date"/>
                </td>
              </tr>
            </xsl:for-each>
          </table>
        </body>
      </html>
    </xsl:template>
</xsl:stylesheet>
