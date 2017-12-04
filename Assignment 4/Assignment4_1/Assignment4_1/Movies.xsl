<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="2.0">
<xsl:template match="/">
<html><body>
<h1>Movies</h1>
<table border ="1"> 
<tr bgcolor="yellow">
<th colspan="2" align="center">Title</th><th rowspan="2">Genre</th><th colspan="3" align="center">Director</th>
<th rowspan="2">Studio</th><th rowspan="2">Year</th><th rowspan="2">Rating</th>
</tr>
<tr bgcolor="green">
<td>Value</td><td>Runtime</td><td>FirstName</td><td>LastName</td><td>High-Rated Movie</td>
</tr>
<xsl:for-each select="Movies/Movie"> 
 <xsl:variable name ="countDirector"  select="count(current()/Director)"/>  
 <tr>
 <td rowspan="{$countDirector}"><xsl:value-of select="Title/Title"/></td>
 <td rowspan="{$countDirector}"><xsl:value-of select="Title/@Runtime"/></td>
 <td rowspan="{$countDirector}"><xsl:value-of select="Genre"/></td>
 <xsl:for-each select="current()/Director">
 <xsl:if test="position()!='1'">
  <tr>
  <td><xsl:value-of select="Name/FirstName"/></td>
  <td><xsl:value-of select="Name/LastName"/></td>
  <td><xsl:value-of select="Name/@High-rated_movie"/></td>
  </tr>
 </xsl:if>
 <xsl:if test="position()= '1'">
  <td><xsl:value-of select="Name/FirstName"/></td>
  <td><xsl:value-of select="Name/LastName"/></td>
  <td><xsl:value-of select="Name/@High-rated_movie"/></td>
  <td rowspan="{$countDirector}"><xsl:value-of select="../Studio"/></td>
  <td rowspan="{$countDirector}"><xsl:value-of select="../Year"/></td>
  <td rowspan="{$countDirector}"><xsl:value-of select="../@Rating"/></td>
</xsl:if>>
 </xsl:for-each>
</tr>
</xsl:for-each>

</table>
</body></html>
</xsl:template>
</xsl:stylesheet>