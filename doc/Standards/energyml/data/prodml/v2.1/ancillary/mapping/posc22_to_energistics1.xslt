<?altova_samplexml file:///D:/work/energistics/witsml_v1.4.1.1_data/xml_examples/rig_no_xsl.xml?>
<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="xml"/>
	<xsl:template name="convert_uom">
		<xsl:param name="nodes"/>
		<xsl:apply-templates select="$nodes"/>
	
	</xsl:template>
	<xsl:template match="@uom">
		<xsl:attribute name="uom">
			<xsl:choose>
				<xsl:when test=".='1/K'">1/deltaK</xsl:when>
				<xsl:when test=".='1/degC'">1/deltaC</xsl:when>
				<xsl:when test=".='1/degF'">1/deltaF</xsl:when>
				<xsl:when test=".='1/degR'">1/deltaR</xsl:when>
				<xsl:when test=".='1/galUK'">1/gal[UK]</xsl:when>
				<xsl:when test=".='1/galUS'">1/gal[US]</xsl:when>
				<xsl:when test=".='1000ft3'">1000 ft3</xsl:when>
				<xsl:when test=".='1000ft3/bbl'">1000 ft3/bbl</xsl:when>
				<xsl:when test=".='1000ft3/d'">1000 ft3/d</xsl:when>
				<xsl:when test=".='1000ft3/d.ft'">1000 ft3/(d.ft)</xsl:when>
				<xsl:when test=".='1000ft3/psi.d'">1000 ft3/(psi.d)</xsl:when>
				<xsl:when test=".='1000m3/d'">1000 m3/d</xsl:when>
				<xsl:when test=".='1000m3/d.m'">1000 m3/(d.m)</xsl:when>
				<xsl:when test=".='1000m3/h'">1000 m3/h</xsl:when>
				<xsl:when test=".='1000m3/h.m'">1000 m3/(h.m)</xsl:when>
				<xsl:when test=".='1000m4/d'">1000 m4/d</xsl:when>
				<xsl:when test=".='100ka'">100 ka[t]</xsl:when>
				<xsl:when test=".='10Mg/m3'">10 Mg/m3</xsl:when>
				<xsl:when test=".='Bd'">bit/s</xsl:when>
				<xsl:when test=".='Btu'">Btu[IT]</xsl:when>
				<xsl:when test=".='Btu(million)/hr'">1E6 Btu[IT]/h</xsl:when>
				<xsl:when test=".='Btu.in/hr.ft2.F'">Btu[IT].in/(h.ft2.deltaF)</xsl:when>
				<xsl:when test=".='Btu/bbl'">Btu[IT]/bbl</xsl:when>
				<xsl:when test=".='Btu/bhp.hr'">Btu[IT]/(hp.h)</xsl:when>
				<xsl:when test=".='Btu/ft3'">Btu[IT]/ft3</xsl:when>
				<xsl:when test=".='Btu/galUK'">Btu[IT]/gal[UK]</xsl:when>
				<xsl:when test=".='Btu/galUS'">Btu[IT]/gal[US]</xsl:when>
				<xsl:when test=".='Btu/hr'">Btu[IT]/h</xsl:when>
				<xsl:when test=".='Btu/hr.ft.degF'">Btu[IT]/(h.ft.deltaF)</xsl:when>
				<xsl:when test=".='Btu/hr.ft2'">Btu[IT]/(h.ft2)</xsl:when>
				<xsl:when test=".='Btu/hr.ft2.degF'">Btu[IT]/(h.ft2.deltaF)</xsl:when>
				<xsl:when test=".='Btu/hr.ft2.degR'">Btu[IT]/(h.ft2.deltaR)</xsl:when>
				<xsl:when test=".='Btu/hr.ft3'">Btu[IT]/(h.ft3)</xsl:when>
				<xsl:when test=".='Btu/hr.ft3.degF'">Btu[IT]/(h.ft3.deltaF)</xsl:when>
				<xsl:when test=".='Btu/hr.m2.degC'">Btu[IT]/(h.m2.deltaC)</xsl:when>
				<xsl:when test=".='Btu/lbm'">Btu[IT]/lbm</xsl:when>
				<xsl:when test=".='Btu/lbm.degF'">Btu[IT]/(lbm.deltaF)</xsl:when>
				<xsl:when test=".='Btu/lbm.degR'">Btu[IT]/(lbm.deltaR)</xsl:when>
				<xsl:when test=".='Btu/lbmole'">Btu[IT]/lbmol</xsl:when>
				<xsl:when test=".='Btu/lbmole.F'">Btu[IT]/(lbmol.deltaF)</xsl:when>
				<xsl:when test=".='Btu/min'">Btu[IT]/min</xsl:when>
				<xsl:when test=".='Btu/mol(lbm)'">Btu[IT]/lbmol</xsl:when>
				<xsl:when test=".='Btu/mol(lbm).F'">Btu[IT]/(lbmol.deltaF)</xsl:when>
				<xsl:when test=".='Btu/s'">Btu[IT]/s</xsl:when>
				<xsl:when test=".='Btu/s.ft2'">Btu[IT]/(s.ft2)</xsl:when>
				<xsl:when test=".='Btu/s.ft2.degF'">Btu[IT]/(s.ft2.deltaF)</xsl:when>
				<xsl:when test=".='Btu/s.ft3'">Btu[IT]/(s.ft3)</xsl:when>
				<xsl:when test=".='Btu/s.ft3.degF'">Btu[IT]/(s.ft3.deltaF)</xsl:when>
				<xsl:when test=".='CV'">hp[metric]</xsl:when>
				<xsl:when test=".='CV.h'">hp[metric].h</xsl:when>
				<xsl:when test=".='Ga'">Ga[t]</xsl:when>
				<xsl:when test=".='Gsm3'">km3</xsl:when>
				<xsl:when test=".='J/K'">J/deltaK</xsl:when>
				<xsl:when test=".='J/g.K'">J/(g.deltaK)</xsl:when>
				<xsl:when test=".='J/kg.K'">J/(kg.deltaK)</xsl:when>
				<xsl:when test=".='J/mol.K'">J/(mol.deltaK)</xsl:when>
				<xsl:when test=".='J/s.m2.degC'">J/(s.m2.deltaC)</xsl:when>
				<xsl:when test=".='K.m2/W'">deltaK.m2/W</xsl:when>
				<xsl:when test=".='K.m2/kW'">deltaK.m2/kW</xsl:when>
				<xsl:when test=".='K/W'">deltaK/W</xsl:when>
				<xsl:when test=".='K/m'">deltaK/m</xsl:when>
				<xsl:when test=".='K/s'">deltaK/s</xsl:when>
				<xsl:when test=".='L/100kg'">0.01 L/kg</xsl:when>
				<xsl:when test=".='L/100km'">0.01 L/km</xsl:when>
				<xsl:when test=".='L/10bbl'">0.1 L/bbl</xsl:when>
				<xsl:when test=".='L/bar.min'">L/(bar.min)</xsl:when>
				<xsl:when test=".='L/km(100)'">0.01 L/km</xsl:when>
				<xsl:when test=".='L/mol(g)'">L/mol</xsl:when>
				<xsl:when test=".='L/mol(kg)'">L/kmol</xsl:when>
				<xsl:when test=".='L/tonUK'">L/ton[UK]</xsl:when>
				<xsl:when test=".='M(ft3)'">1E6 ft3</xsl:when>
				<xsl:when test=".='M(ft3)/acre.ft'">1E6 ft3/(acre.ft)</xsl:when>
				<xsl:when test=".='M(ft3)/d'">1E6 ft3/d</xsl:when>
				<xsl:when test=".='M(m3)'">1E6 m3</xsl:when>
				<xsl:when test=".='M(m3)/d'">1E6 m3/d</xsl:when>
				<xsl:when test=".='MBtu/hr'">1E6 Btu[IT]/h</xsl:when>
				<xsl:when test=".='MJ/mol(kg)'">MJ/kmol</xsl:when>
				<xsl:when test=".='MMbbl'">1E6 bbl</xsl:when>
				<xsl:when test=".='MMbbl/acre.ft'">1E6 bbl/(acre.ft)</xsl:when>
				<xsl:when test=".='MMcf'">1E6 ft3</xsl:when>
				<xsl:when test=".='MMscf(60F)'">1E6 ft3</xsl:when>
				<xsl:when test=".='MMscf(60F)/d'">1E6 ft3/d</xsl:when>
				<xsl:when test=".='MMscf60/stb60'">1E6 ft3/bbl</xsl:when>
				<xsl:when test=".='MMscm(15C)'">1E6 m3</xsl:when>
				<xsl:when test=".='MMscm(15C)/d'">1E6 m3/d</xsl:when>
				<xsl:when test=".='MMstb(60F)'">1E6 bbl</xsl:when>
				<xsl:when test=".='MMstb(60F)/d'">1E6 bbl/d</xsl:when>
				<xsl:when test=".='MMstb/acre'">1E6 bbl/acre</xsl:when>
				<xsl:when test=".='MMstb/acre.ft'">1E6 bbl/(acre.ft)</xsl:when>
				<xsl:when test=".='MY'">Ma[t]</xsl:when>
				<xsl:when test=".='Ma'">Ma[t]</xsl:when>
				<xsl:when test=".='Mbbl'">1000 bbl</xsl:when>
				<xsl:when test=".='Mbbl.ft/d'">1000 bbl.ft/d</xsl:when>
				<xsl:when test=".='Mbbl/d'">1000 bbl/d</xsl:when>
				<xsl:when test=".='Mbyte'">Mibyte</xsl:when>
				<xsl:when test=".='Mcf'">1000 ft3</xsl:when>
				<xsl:when test=".='Mflops'">1/us</xsl:when>
				<xsl:when test=".='Mlbm/yr'">1E6 lbm/a</xsl:when>
				<xsl:when test=".='Mscf(60F)'">1000 ft3</xsl:when>
				<xsl:when test=".='Mscf(60F)/d'">1000 ft3/d</xsl:when>
				<xsl:when test=".='Mscf60/stb60'">1000 ft3/bbl</xsl:when>
				<xsl:when test=".='Mscm(15C)/d'">1000 m3/d</xsl:when>
				<xsl:when test=".='Msm3'">1E6 m3</xsl:when>
				<xsl:when test=".='Mstb(60F)'">1000 bbl</xsl:when>
				<xsl:when test=".='Mstb(60F)/d'">1000 bbl/d</xsl:when>
				<xsl:when test=".='N/30m'">1/30 N/m</xsl:when>
				<xsl:when test=".='Pa(g)'">Pa</xsl:when>
				<xsl:when test=".='W/K'">W/deltaK</xsl:when>
				<xsl:when test=".='W/m.K'">W/(m.deltaK)</xsl:when>
				<xsl:when test=".='W/m2.K'">W/(m2.deltaK)</xsl:when>
				<xsl:when test=".='W/m2.sr'">W/(m2.sr)</xsl:when>
				<xsl:when test=".='W/m3.K'">W/(m3.deltaK)</xsl:when>
				<xsl:when test=".='acre.ft/MMstb'">1E-6 acre.ft/bbl</xsl:when>
				<xsl:when test=".='bbl/100bbl'">0.01 bbl/bbl</xsl:when>
				<xsl:when test=".='bbl/M(ft3)'">1E-6 bbl/ft3</xsl:when>
				<xsl:when test=".='bbl/MMscf(60F)'">1E-6 bbl/ft3</xsl:when>
				<xsl:when test=".='bbl/acre.ft'">bbl/(acre.ft)</xsl:when>
				<xsl:when test=".='bbl/d.acre.ft'">bbl/(d.acre.ft)</xsl:when>
				<xsl:when test=".='bbl/d.ft'">bbl/(d.ft)</xsl:when>
				<xsl:when test=".='bbl/d.ft.psi'">bbl/(ft.psi.d)</xsl:when>
				<xsl:when test=".='bbl/d.psi'">bbl/(psi.d)</xsl:when>
				<xsl:when test=".='bbl/hr'">bbl/h</xsl:when>
				<xsl:when test=".='bbl/hr2'">bbl/h2</xsl:when>
				<xsl:when test=".='bbl/k(ft3)'">0.001 bbl/ft3</xsl:when>
				<xsl:when test=".='bbl/kPa.d'">bbl/(kPa.d)</xsl:when>
				<xsl:when test=".='bbl/psi.d'">bbl/(psi.d)</xsl:when>
				<xsl:when test=".='bbl/stb(60F)'">bbl/bbl</xsl:when>
				<xsl:when test=".='bbl/tonUK'">bbl/ton[UK]</xsl:when>
				<xsl:when test=".='bbl/tonUS'">bbl/ton[US]</xsl:when>
				<xsl:when test=".='bblPft'">bbl/ft</xsl:when>
				<xsl:when test=".='bcf'">1E9 ft3</xsl:when>
				<xsl:when test=".='bps'">bit/s</xsl:when>
				<xsl:when test=".='c'">rev</xsl:when>
				<xsl:when test=".='c/s'">rev/s</xsl:when>
				<xsl:when test=".='cal'">cal[th]</xsl:when>
				<xsl:when test=".='cal/cm3'">cal[th]/cm3</xsl:when>
				<xsl:when test=".='cal/g'">cal[th]/g</xsl:when>
				<xsl:when test=".='cal/g.K'">cal[th]/(g.deltaK)</xsl:when>
				<xsl:when test=".='cal/h.cm.degC'">cal[th]/(h.cm.deltaC)</xsl:when>
				<xsl:when test=".='cal/h.cm2'">cal[th]/(h.cm2)</xsl:when>
				<xsl:when test=".='cal/h.cm2.degC'">cal[th]/(h.cm2.deltaC)</xsl:when>
				<xsl:when test=".='cal/h.cm3'">cal[th]/(h.cm3)</xsl:when>
				<xsl:when test=".='cal/kg'">cal[th]/kg</xsl:when>
				<xsl:when test=".='cal/lbm'">cal[th]/lbm</xsl:when>
				<xsl:when test=".='cal/mL'">cal[th]/mL</xsl:when>
				<xsl:when test=".='cal/mm3'">cal[th]/mm3</xsl:when>
				<xsl:when test=".='cal/mol(g).degC'">cal[th]/(mol.deltaC)</xsl:when>
				<xsl:when test=".='cal/mol.degC'">cal[th]/(mol.deltaC)</xsl:when>
				<xsl:when test=".='cal/s.cm.degC'">cal[th]/(s.cm.deltaC)</xsl:when>
				<xsl:when test=".='cal/s.cm2.degC'">cal[th]/(s.cm2.deltaC)</xsl:when>
				<xsl:when test=".='cal/s.cm3'">cal[th]/(s.cm3)</xsl:when>
				<xsl:when test=".='ch'">hp[metric]</xsl:when>
				<xsl:when test=".='ch.h'">hp[metric].h</xsl:when>
				<xsl:when test=".='chBnA'">chain[BnA]</xsl:when>
				<xsl:when test=".='chBnB'">chain[BnB]</xsl:when>
				<xsl:when test=".='chCla'">chain[Cla]</xsl:when>
				<xsl:when test=".='chSe'">chain[Se]</xsl:when>
				<xsl:when test=".='chUS'">chain[US]</xsl:when>
				<xsl:when test=".='cm3/30min'">1/30 cm3/min</xsl:when>
				<xsl:when test=".='cmH2O(4degC)'">cmH2O[4degC]</xsl:when>
				<xsl:when test=".='cu ft'">ft3</xsl:when>
				<xsl:when test=".='cu in'">in3</xsl:when>
				<xsl:when test=".='cu yd'">yd3</xsl:when>
				<xsl:when test=".='cubem'">mi3</xsl:when>
				<xsl:when test=".='curie'">Ci</xsl:when>
				<xsl:when test=".='cwtUK'">cwt[UK]</xsl:when>
				<xsl:when test=".='cwtUS'">cwt[US]</xsl:when>
				<xsl:when test=".='d/k(ft3)'">0.001 d/ft3</xsl:when>
				<xsl:when test=".='ddegC'">deltaC</xsl:when>
				<xsl:when test=".='ddegF'">deltaF</xsl:when>
				<xsl:when test=".='ddegK'">deltaK</xsl:when>
				<xsl:when test=".='ddegR'">deltaR</xsl:when>
				<xsl:when test=".='degC.m2.h/kcal'">deltaC.m2.h/kcal[th]</xsl:when>
				<xsl:when test=".='degC/100m'">deltaC/hm</xsl:when>
				<xsl:when test=".='degC/ft'">deltaC/ft</xsl:when>
				<xsl:when test=".='degC/h'">deltaC/h</xsl:when>
				<xsl:when test=".='degC/km'">deltaC/km</xsl:when>
				<xsl:when test=".='degC/m'">deltaC/m</xsl:when>
				<xsl:when test=".='degC/min'">deltaC/min</xsl:when>
				<xsl:when test=".='degC/s'">deltaC/s</xsl:when>
				<xsl:when test=".='degF.ft2.h/Btu'">deltaF.ft2.h/Btu[IT]</xsl:when>
				<xsl:when test=".='degF/100ft'">0.01 deltaF/ft</xsl:when>
				<xsl:when test=".='degF/ft'">deltaF/ft</xsl:when>
				<xsl:when test=".='degF/ft(100)'">0.01 deltaF/ft</xsl:when>
				<xsl:when test=".='degF/h'">deltaF/h</xsl:when>
				<xsl:when test=".='degF/m'">deltaF/m</xsl:when>
				<xsl:when test=".='degF/min'">deltaF/min</xsl:when>
				<xsl:when test=".='degF/s'">deltaF/s</xsl:when>
				<xsl:when test=".='dega/100ft'">0.01 dega/ft</xsl:when>
				<xsl:when test=".='dega/30ft'">1/30 dega/ft</xsl:when>
				<xsl:when test=".='dega/30m'">1/30 dega/m</xsl:when>
				<xsl:when test=".='dega/ft(100)'">0.01 dega/ft</xsl:when>
				<xsl:when test=".='dega/m(30)'">1/30 dega/m</xsl:when>
				<xsl:when test=".='dm3/100km'">0.01 dm3/km</xsl:when>
				<xsl:when test=".='dm3/kW.h'">dm3/(kW.h)</xsl:when>
				<xsl:when test=".='dm3/km(100)'">0.01 dm3/km</xsl:when>
				<xsl:when test=".='dm3/mol(kg)'">dm3/kmol</xsl:when>
				<xsl:when test=".='ehp'">hp[elec]</xsl:when>
				<xsl:when test=".='fl ozUK'">floz[UK]</xsl:when>
				<xsl:when test=".='fl ozUS'">floz[US]</xsl:when>
				<xsl:when test=".='flops'">1/s</xsl:when>
				<xsl:when test=".='flozUK'">floz[UK]</xsl:when>
				<xsl:when test=".='flozUS'">floz[US]</xsl:when>
				<xsl:when test=".='ft.lbf'">lbf.ft</xsl:when>
				<xsl:when test=".='ft.lbf/bbl'">lbf.ft/bbl</xsl:when>
				<xsl:when test=".='ft.lbf/galUS'">lbf.ft/gal[US]</xsl:when>
				<xsl:when test=".='ft.lbf/lbm'">lbf.ft/lbm</xsl:when>
				<xsl:when test=".='ft.lbf/min'">lbf.ft/min</xsl:when>
				<xsl:when test=".='ft.lbf/s'">lbf.ft/s</xsl:when>
				<xsl:when test=".='ft.lbm'">lbm.ft</xsl:when>
				<xsl:when test=".='ft/100ft'">0.01 ft/ft</xsl:when>
				<xsl:when test=".='ft/degF'">ft/deltaF</xsl:when>
				<xsl:when test=".='ft/galUS'">ft/gal[US]</xsl:when>
				<xsl:when test=".='ft3(std,60F)'">ft3</xsl:when>
				<xsl:when test=".='ft3/d.ft.psi'">ft3/(ft.psi.d)</xsl:when>
				<xsl:when test=".='ft3/lbmole'">ft3/lbmol</xsl:when>
				<xsl:when test=".='ft3/min.ft2'">ft3/(min.ft2)</xsl:when>
				<xsl:when test=".='ft3/mol(lbm)'">ft3/lbmol</xsl:when>
				<xsl:when test=".='ft3/s.ft2'">ft3/(s.ft2)</xsl:when>
				<xsl:when test=".='ft3/sack94'">ft3/sack[94lbm]</xsl:when>
				<xsl:when test=".='ft3/scf(60F)'">ft3/ft3</xsl:when>
				<xsl:when test=".='ftBnA'">ft[BnA]</xsl:when>
				<xsl:when test=".='ftBnB'">ft[BnB]</xsl:when>
				<xsl:when test=".='ftBr(65)'">ft[Br65]</xsl:when>
				<xsl:when test=".='ftCla'">ft[Cla]</xsl:when>
				<xsl:when test=".='ftGC'">ft[GC]</xsl:when>
				<xsl:when test=".='ftInd'">ft[Ind]</xsl:when>
				<xsl:when test=".='ftInd(37)'">ft[Ind37]</xsl:when>
				<xsl:when test=".='ftInd(62)'">ft[Ind62]</xsl:when>
				<xsl:when test=".='ftInd(75)'">ft[Ind75]</xsl:when>
				<xsl:when test=".='ftSe'">ft[Se]</xsl:when>
				<xsl:when test=".='ftUS'">ft[US]</xsl:when>
				<xsl:when test=".='g.ft/cm3.s'">g.ft/(cm3.s)</xsl:when>
				<xsl:when test=".='g/galUK'">g/gal[UK]</xsl:when>
				<xsl:when test=".='g/galUS'">g/gal[US]</xsl:when>
				<xsl:when test=".='gal/sack'">gal[US]/sack[94lbm]</xsl:when>
				<xsl:when test=".='galUK'">gal[UK]</xsl:when>
				<xsl:when test=".='galUK/Mbbl'">0.001 gal[UK]/bbl</xsl:when>
				<xsl:when test=".='galUK/d'">gal[UK]/d</xsl:when>
				<xsl:when test=".='galUK/ft3'">gal[UK]/ft3</xsl:when>
				<xsl:when test=".='galUK/hr'">gal[UK]/h</xsl:when>
				<xsl:when test=".='galUK/hr.ft'">gal[UK]/(h.ft)</xsl:when>
				<xsl:when test=".='galUK/hr.ft2'">gal[UK]/(h.ft2)</xsl:when>
				<xsl:when test=".='galUK/hr.in'">gal[UK]/(h.in)</xsl:when>
				<xsl:when test=".='galUK/hr.in2'">gal[UK]/(h.in2)</xsl:when>
				<xsl:when test=".='galUK/hr2'">gal[UK]/h2</xsl:when>
				<xsl:when test=".='galUK/kgalUK'">0.001 gal[UK]/gal[UK]</xsl:when>
				<xsl:when test=".='galUK/lbm'">gal[UK]/lbm</xsl:when>
				<xsl:when test=".='galUK/mi'">gal[UK]/mi</xsl:when>
				<xsl:when test=".='galUK/min'">gal[UK]/min</xsl:when>
				<xsl:when test=".='galUK/min.ft'">gal[UK]/(min.ft)</xsl:when>
				<xsl:when test=".='galUK/min.ft2'">gal[UK]/(min.ft2)</xsl:when>
				<xsl:when test=".='galUK/min2'">gal[UK]/min2</xsl:when>
				<xsl:when test=".='galUS'">gal[US]</xsl:when>
				<xsl:when test=".='galUS/10bbl'">0.1 gal[US]/bbl</xsl:when>
				<xsl:when test=".='galUS/Mbbl'">0.001 gal[US]/bbl</xsl:when>
				<xsl:when test=".='galUS/Mscf(60F)'">0.001 gal[US]/ft3</xsl:when>
				<xsl:when test=".='galUS/bbl'">gal[US]/bbl</xsl:when>
				<xsl:when test=".='galUS/d'">gal[US]/d</xsl:when>
				<xsl:when test=".='galUS/ft'">gal[US]/ft</xsl:when>
				<xsl:when test=".='galUS/ft3'">gal[US]/ft3</xsl:when>
				<xsl:when test=".='galUS/hr'">gal[US]/h</xsl:when>
				<xsl:when test=".='galUS/hr.ft'">gal[US]/(h.ft)</xsl:when>
				<xsl:when test=".='galUS/hr.ft2'">gal[US]/(h.ft2)</xsl:when>
				<xsl:when test=".='galUS/hr.in'">gal[US]/(h.in)</xsl:when>
				<xsl:when test=".='galUS/hr.in2'">gal[US]/(h.in2)</xsl:when>
				<xsl:when test=".='galUS/hr2'">gal[US]/h2</xsl:when>
				<xsl:when test=".='galUS/kgalUS'">0.001 gal[US]/gal[US]</xsl:when>
				<xsl:when test=".='galUS/lbm'">gal[US]/lbm</xsl:when>
				<xsl:when test=".='galUS/mi'">gal[US]/mi</xsl:when>
				<xsl:when test=".='galUS/min'">gal[US]/min</xsl:when>
				<xsl:when test=".='galUS/min.ft'">gal[US]/(min.ft)</xsl:when>
				<xsl:when test=".='galUS/min.ft2'">gal[US]/(min.ft2)</xsl:when>
				<xsl:when test=".='galUS/min2'">gal[US]/min2</xsl:when>
				<xsl:when test=".='galUS/sack94'">gal[US]/sack[94lbm]</xsl:when>
				<xsl:when test=".='galUS/tonUK'">gal[US]/ton[UK]</xsl:when>
				<xsl:when test=".='galUS/tonUS'">gal[US]/ton[US]</xsl:when>
				<xsl:when test=".='gr'">gon</xsl:when>
				<xsl:when test=".='grain/100ft3'">0.01 grain/ft3</xsl:when>
				<xsl:when test=".='grain/ft3(100)'">0.01 grain/ft3</xsl:when>
				<xsl:when test=".='grain/galUS'">grain/gal[US]</xsl:when>
				<xsl:when test=".='h/kft'">0.001 h/ft</xsl:when>
				<xsl:when test=".='hhp'">hp[hyd]</xsl:when>
				<xsl:when test=".='hhp/in2'">hp[hyd]/in2</xsl:when>
				<xsl:when test=".='hp.hr'">hp.h</xsl:when>
				<xsl:when test=".='hp.hr/bbl'">hp.h/bbl</xsl:when>
				<xsl:when test=".='hp.hr/lbm'">hp.h/lbm</xsl:when>
				<xsl:when test=".='in/10'">0.1 in</xsl:when>
				<xsl:when test=".='in/16'">1/16 in</xsl:when>
				<xsl:when test=".='in/32'">1/32 in</xsl:when>
				<xsl:when test=".='in/64'">1/64 in</xsl:when>
				<xsl:when test=".='in/in.degF'">in/(in.deltaF)</xsl:when>
				<xsl:when test=".='inH2O(39.2F)'">inH2O[39degF]</xsl:when>
				<xsl:when test=".='inH2O(60F)'">inH2O[60degF]</xsl:when>
				<xsl:when test=".='inHg(32F)'">inHg[32degF]</xsl:when>
				<xsl:when test=".='inHg(60F)'">inHg[60degF]</xsl:when>
				<xsl:when test=".='inUS'">in[US]</xsl:when>
				<xsl:when test=".='kEuc/s'">1/ms</xsl:when>
				<xsl:when test=".='kJ.m/h.m2.K'">kJ.m/(h.m2.deltaK)</xsl:when>
				<xsl:when test=".='kJ/h.m2.K'">kJ/(h.m2.deltaK)</xsl:when>
				<xsl:when test=".='kJ/kg.K'">kJ/(kg.deltaK)</xsl:when>
				<xsl:when test=".='kJ/kmol.K'">kJ/(kmol.deltaK)</xsl:when>
				<xsl:when test=".='kJ/mol(kg)'">kJ/kmol</xsl:when>
				<xsl:when test=".='kJ/mol(kg).K'">kJ/(kmol.deltaK)</xsl:when>
				<xsl:when test=".='kPa/100m'">kPa/hm</xsl:when>
				<xsl:when test=".='kPa2/kcP'">0.001 kPa2/cP</xsl:when>
				<xsl:when test=".='kW.h/kg.degC'">kW.h/(kg.deltaC)</xsl:when>
				<xsl:when test=".='kW/m2.K'">kW/(m2.deltaK)</xsl:when>
				<xsl:when test=".='kW/m3.K'">kW/(m3.deltaK)</xsl:when>
				<xsl:when test=".='kbbl/d'">1000 bbl/d</xsl:when>
				<xsl:when test=".='kbyte'">Kibyte</xsl:when>
				<xsl:when test=".='kcal'">kcal[th]</xsl:when>
				<xsl:when test=".='kcal.m/cm2'">kcal[th].m/cm2</xsl:when>
				<xsl:when test=".='kcal/cm3'">kcal[th]/cm3</xsl:when>
				<xsl:when test=".='kcal/g'">kcal[th]/g</xsl:when>
				<xsl:when test=".='kcal/h'">kcal[th]/h</xsl:when>
				<xsl:when test=".='kcal/h.m.degC'">kcal[th]/(h.m.deltaC)</xsl:when>
				<xsl:when test=".='kcal/h.m2.degC'">kcal[th]/(h.m2.deltaC)</xsl:when>
				<xsl:when test=".='kcal/kg'">kcal[th]/kg</xsl:when>
				<xsl:when test=".='kcal/kg.degC'">kcal[th]/(kg.deltaC)</xsl:when>
				<xsl:when test=".='kcal/m3'">kcal[th]/m3</xsl:when>
				<xsl:when test=".='kcal/mol'">kcal[th]/mol</xsl:when>
				<xsl:when test=".='kcal/mol(g)'">kcal[th]/mol</xsl:when>
				<xsl:when test=".='kft.lbf'">1000 lbf.ft</xsl:when>
				<xsl:when test=".='kft/h'">1000 ft/h</xsl:when>
				<xsl:when test=".='kft/s'">1000 ft/s</xsl:when>
				<xsl:when test=".='kg/kW.h'">kg/(kW.h)</xsl:when>
				<xsl:when test=".='kg/m.s'">kg/(m.s)</xsl:when>
				<xsl:when test=".='kg/m2.s'">kg/(m2.s)</xsl:when>
				<xsl:when test=".='kg/sack94'">kg/sack[94lbm]</xsl:when>
				<xsl:when test=".='ksm3'">1000 m3</xsl:when>
				<xsl:when test=".='ksm3/d'">1000 m3/d</xsl:when>
				<xsl:when test=".='ksm3/sm3'">1000 m3/m3</xsl:when>
				<xsl:when test=".='lbf/100ft'">0.01 lbf/ft</xsl:when>
				<xsl:when test=".='lbf/100ft2'">0.01 lbf/ft2</xsl:when>
				<xsl:when test=".='lbf/30m'">1/30 lbf/m</xsl:when>
				<xsl:when test=".='lbf/ft2(100)'">0.01 lbf/ft2</xsl:when>
				<xsl:when test=".='lbf/galUS'">lbf/gal[US]</xsl:when>
				<xsl:when test=".='lbf/in2'">psi</xsl:when>
				<xsl:when test=".='lbm(million)/yr'">1E6 lbm/a</xsl:when>
				<xsl:when test=".='lbm/1000galUK'">0.001 lbm/gal[UK]</xsl:when>
				<xsl:when test=".='lbm/1000galUS'">0.001 lbm/gal[US]</xsl:when>
				<xsl:when test=".='lbm/100ft2'">0.01 lbm/ft2</xsl:when>
				<xsl:when test=".='lbm/10bbl'">0.1 lbm/bbl</xsl:when>
				<xsl:when test=".='lbm/Mbbl'">0.001 lbm/bbl</xsl:when>
				<xsl:when test=".='lbm/ft.h'">lbm/(ft.h)</xsl:when>
				<xsl:when test=".='lbm/ft.s'">lbm/(ft.s)</xsl:when>
				<xsl:when test=".='lbm/galUK'">lbm/gal[UK]</xsl:when>
				<xsl:when test=".='lbm/galUK(1000)'">0.001 lbm/gal[UK]</xsl:when>
				<xsl:when test=".='lbm/galUK.ft'">lbm/(gal[UK].ft)</xsl:when>
				<xsl:when test=".='lbm/galUS'">lbm/gal[US]</xsl:when>
				<xsl:when test=".='lbm/galUS(1000)'">0.001 lbm/gal[US]</xsl:when>
				<xsl:when test=".='lbm/galUS.ft'">lbm/(gal[US].ft)</xsl:when>
				<xsl:when test=".='lbm/h.ft'">lbm/(ft.h)</xsl:when>
				<xsl:when test=".='lbm/h.ft2'">lbm/(ft2.h)</xsl:when>
				<xsl:when test=".='lbm/hp.h'">lbm/(hp.h)</xsl:when>
				<xsl:when test=".='lbm/s.ft'">lbm/(ft.s)</xsl:when>
				<xsl:when test=".='lbm/s.ft2'">lbm/(ft2.s)</xsl:when>
				<xsl:when test=".='lbmole'">lbmol</xsl:when>
				<xsl:when test=".='lbmole/ft3'">lbmol/ft3</xsl:when>
				<xsl:when test=".='lbmole/galUK'">lbmol/gal[UK]</xsl:when>
				<xsl:when test=".='lbmole/galUS'">lbmol/gal[US]</xsl:when>
				<xsl:when test=".='lbmole/h'">lbmol/h</xsl:when>
				<xsl:when test=".='lbmole/h.ft2'">lbmol/(h.ft2)</xsl:when>
				<xsl:when test=".='lbmole/s'">lbmol/s</xsl:when>
				<xsl:when test=".='lbmole/s.ft2'">lbmol/(s.ft2)</xsl:when>
				<xsl:when test=".='lkBnA'">link[BnA]</xsl:when>
				<xsl:when test=".='lkBnB'">link[BnB]</xsl:when>
				<xsl:when test=".='lkCla'">link[Cla]</xsl:when>
				<xsl:when test=".='lkSe'">link[Se]</xsl:when>
				<xsl:when test=".='lkUS'">link[US]</xsl:when>
				<xsl:when test=".='m/30m'">1/30 m/m</xsl:when>
				<xsl:when test=".='m/K'">m/deltaK</xsl:when>
				<xsl:when test=".='m/m.K'">m/(m.deltaK)</xsl:when>
				<xsl:when test=".='m2/Pa.s'">m2/(Pa.s)</xsl:when>
				<xsl:when test=".='m2/d.kPa'">m2/(kPa.d)</xsl:when>
				<xsl:when test=".='m3/Pa.s'">m3/(Pa.s)</xsl:when>
				<xsl:when test=".='m3/Pa/s'">m3/(Pa.s)</xsl:when>
				<xsl:when test=".='m3/bar.d'">m3/(bar.d)</xsl:when>
				<xsl:when test=".='m3/bar.h'">m3/(bar.h)</xsl:when>
				<xsl:when test=".='m3/bar.min'">m3/(bar.min)</xsl:when>
				<xsl:when test=".='m3/d.kPa'">m3/(kPa.d)</xsl:when>
				<xsl:when test=".='m3/d.m'">m3/(d.m)</xsl:when>
				<xsl:when test=".='m3/h.m'">m3/(h.m)</xsl:when>
				<xsl:when test=".='m3/ha.m'">m3/(ha.m)</xsl:when>
				<xsl:when test=".='m3/kPa.d'">m3/(kPa.d)</xsl:when>
				<xsl:when test=".='m3/kPa.h'">m3/(kPa.h)</xsl:when>
				<xsl:when test=".='m3/kW.h'">m3/(kW.h)</xsl:when>
				<xsl:when test=".='m3/mol(kg)'">m3/kmol</xsl:when>
				<xsl:when test=".='m3/psi.d'">m3/(psi.d)</xsl:when>
				<xsl:when test=".='m3/s.ft'">m3/(s.ft)</xsl:when>
				<xsl:when test=".='m3/s.m'">m3/(s.m)</xsl:when>
				<xsl:when test=".='m3/s.m2'">m3/(s.m2)</xsl:when>
				<xsl:when test=".='m3/scm(0C)'">m3/m3</xsl:when>
				<xsl:when test=".='m3/scm(15C)'">m3/m3</xsl:when>
				<xsl:when test=".='m3/tonUK'">m3/ton[UK]</xsl:when>
				<xsl:when test=".='m3/tonUS'">m3/ton[US]</xsl:when>
				<xsl:when test=".='mD.ft2/lbf.s'">mD.ft2/(lbf.s)</xsl:when>
				<xsl:when test=".='mD.in2/lbf.s'">mD.in2/(lbf.s)</xsl:when>
				<xsl:when test=".='mD/Pa.s'">mD/(Pa.s)</xsl:when>
				<xsl:when test=".='mGer'">m[Ger]</xsl:when>
				<xsl:when test=".='mK/m'">deltaK/km</xsl:when>
				<xsl:when test=".='mL/galUK'">mL/gal[UK]</xsl:when>
				<xsl:when test=".='mL/galUS'">mL/gal[US]</xsl:when>
				<xsl:when test=".='mcurie'">mCi</xsl:when>
				<xsl:when test=".='mg/galUS'">mg/gal[US]</xsl:when>
				<xsl:when test=".='mho'">S</xsl:when>
				<xsl:when test=".='mho/m'">S/m</xsl:when>
				<xsl:when test=".='mi/galUK'">mi/gal[UK]</xsl:when>
				<xsl:when test=".='mi/galUS'">mi/gal[US]</xsl:when>
				<xsl:when test=".='miUS'">mi[US]</xsl:when>
				<xsl:when test=".='miUS2'">mi[US]2</xsl:when>
				<xsl:when test=".='mil/yr'">mil/a</xsl:when>
				<xsl:when test=".='mm/mm.K'">mm/(mm.deltaK)</xsl:when>
				<xsl:when test=".='mmHg(0C)'">mmHg[0degC]</xsl:when>
				<xsl:when test=".='mmho/m'">mS/m</xsl:when>
				<xsl:when test=".='mol(g)'">mol</xsl:when>
				<xsl:when test=".='mol(kg)'">kmol</xsl:when>
				<xsl:when test=".='mol(kg)/h'">kmol/h</xsl:when>
				<xsl:when test=".='mol(kg)/m3'">kmol/m3</xsl:when>
				<xsl:when test=".='mol(kg)/s'">kmol/s</xsl:when>
				<xsl:when test=".='mol(lbm)'">lbmol</xsl:when>
				<xsl:when test=".='mol(lbm)/ft3'">lbmol/ft3</xsl:when>
				<xsl:when test=".='mol(lbm)/galUK'">lbmol/gal[UK]</xsl:when>
				<xsl:when test=".='mol(lbm)/galUS'">lbmol/gal[US]</xsl:when>
				<xsl:when test=".='mol(lbm)/h'">lbmol/h</xsl:when>
				<xsl:when test=".='mol(lbm)/h.ft2'">lbmol/(h.ft2)</xsl:when>
				<xsl:when test=".='mol(lbm)/s'">lbmol/s</xsl:when>
				<xsl:when test=".='mol(lbm)/s.ft2'">lbmol/(s.ft2)</xsl:when>
				<xsl:when test=".='mol/m2.s'">mol/(s.m2)</xsl:when>
				<xsl:when test=".='ms/2'">1/2 ms</xsl:when>
				<xsl:when test=".='mseca'">0.001 seca</xsl:when>
				<xsl:when test=".='nautmi'">mi[naut]</xsl:when>
				<xsl:when test=".='ncurie'">nCi</xsl:when>
				<xsl:when test=".='oz(av)'">ozm</xsl:when>
				<xsl:when test=".='oz(troy)'">ozm[troy]</xsl:when>
				<xsl:when test=".='pcurie'">pCi</xsl:when>
				<xsl:when test=".='permil'">ppk</xsl:when>
				<xsl:when test=".='ppm/degC'">ppm[vol]/deltaC</xsl:when>
				<xsl:when test=".='ppm/degF'">ppm[vol]/deltaF</xsl:when>
				<xsl:when test=".='psf'">lbf/ft2</xsl:when>
				<xsl:when test=".='psi/100ft'">0.01 psi/ft</xsl:when>
				<xsl:when test=".='psi/ft(100)'">0.01 psi/ft</xsl:when>
				<xsl:when test=".='psi/kft'">0.001 psi/ft</xsl:when>
				<xsl:when test=".='psi2.d/cP.ft3'">psi2.d/(cP.ft3)</xsl:when>
				<xsl:when test=".='psi2.d/cp.ft3'">psi2.d/(cP.ft3)</xsl:when>
				<xsl:when test=".='psia'">psi</xsl:when>
				<xsl:when test=".='psig'">psi</xsl:when>
				<xsl:when test=".='ptUK'">pt[UK]</xsl:when>
				<xsl:when test=".='ptUK/Mbbl'">0.001 pt[UK]/bbl</xsl:when>
				<xsl:when test=".='ptUK/hp.hr'">pt[UK]/(hp.h)</xsl:when>
				<xsl:when test=".='ptUS'">pt[US]</xsl:when>
				<xsl:when test=".='ptUS/10bbl'">0.1 pt[US]/bbl</xsl:when>
				<xsl:when test=".='qtUK'">qt[UK]</xsl:when>
				<xsl:when test=".='qtUS'">qt[US]</xsl:when>
				<xsl:when test=".='quad/yr'">quad/a</xsl:when>
				<xsl:when test=".='rev/min'">rpm</xsl:when>
				<xsl:when test=".='s/qtUK'">s/qt[UK]</xsl:when>
				<xsl:when test=".='s/qtUS'">s/qt[US]</xsl:when>
				<xsl:when test=".='sack94'">sack[94lbm]</xsl:when>
				<xsl:when test=".='scf(60F)'">ft3</xsl:when>
				<xsl:when test=".='scf(60F)/bbl'">ft3/bbl</xsl:when>
				<xsl:when test=".='scf(60F)/d'">ft3/d</xsl:when>
				<xsl:when test=".='scf(60F)/ft2'">ft3/ft2</xsl:when>
				<xsl:when test=".='scf(60F)/ft3'">ft3/ft3</xsl:when>
				<xsl:when test=".='scm(0C)'">m3</xsl:when>
				<xsl:when test=".='scm(0C)/m2'">m3/m2</xsl:when>
				<xsl:when test=".='scm(0C)/m3'">m3/m3</xsl:when>
				<xsl:when test=".='scm(15C)'">m3</xsl:when>
				<xsl:when test=".='scm(15C)/d'">m3/d</xsl:when>
				<xsl:when test=".='scm(15C)/m2'">m3/m2</xsl:when>
				<xsl:when test=".='scm(15C)/m3'">m3/m3</xsl:when>
				<xsl:when test=".='scm(15C)/s'">m3/s</xsl:when>
				<xsl:when test=".='scm15/stb60'">m3/bbl</xsl:when>
				<xsl:when test=".='sigma'">cu</xsl:when>
				<xsl:when test=".='sm3/ksm3'">dm3/m3</xsl:when>
				<xsl:when test=".='sm3/sm3'">m3/m3</xsl:when>
				<xsl:when test=".='sq ft'">ft2</xsl:when>
				<xsl:when test=".='sq in'">in2</xsl:when>
				<xsl:when test=".='sq mi'">mi2</xsl:when>
				<xsl:when test=".='sq yd'">yd2</xsl:when>
				<xsl:when test=".='stb(60F)'">bbl</xsl:when>
				<xsl:when test=".='stb(60F)/acre'">bbl/acre</xsl:when>
				<xsl:when test=".='stb(60F)/bbl'">bbl/bbl</xsl:when>
				<xsl:when test=".='stb(60F)/d'">bbl/d</xsl:when>
				<xsl:when test=".='stb60/MMscf60'">1E-6 bbl/ft3</xsl:when>
				<xsl:when test=".='stb60/MMscm15'">1E-6 bbl/m3</xsl:when>
				<xsl:when test=".='stb60/Mscf60'">0.001 bbl/ft3</xsl:when>
				<xsl:when test=".='stb60/Mscm15'">0.001 bbl/m3</xsl:when>
				<xsl:when test=".='stb60/scm15'">bbl/m3</xsl:when>
				<xsl:when test=".='talbot'">lm.s</xsl:when>
				<xsl:when test=".='tcf'">1E12 ft3</xsl:when>
				<xsl:when test=".='therm'">therm[UK]</xsl:when>
				<xsl:when test=".='ton of refrig'">tonRefrig</xsl:when>
				<xsl:when test=".='tonUK'">ton[UK]</xsl:when>
				<xsl:when test=".='tonUK/a'">ton[UK]/a</xsl:when>
				<xsl:when test=".='tonUK/d'">ton[UK]/d</xsl:when>
				<xsl:when test=".='tonUK/h'">ton[UK]/h</xsl:when>
				<xsl:when test=".='tonUK/min'">ton[UK]/min</xsl:when>
				<xsl:when test=".='tonUS'">ton[US]</xsl:when>
				<xsl:when test=".='tonUS/a'">ton[US]/a</xsl:when>
				<xsl:when test=".='tonUS/d'">ton[US]/d</xsl:when>
				<xsl:when test=".='tonUS/ft2'">ton[US]/ft2</xsl:when>
				<xsl:when test=".='tonUS/h'">ton[US]/h</xsl:when>
				<xsl:when test=".='tonUS/min'">ton[US]/min</xsl:when>
				<xsl:when test=".='tonfUK'">tonf[UK]</xsl:when>
				<xsl:when test=".='tonfUK.ft2'">tonf[UK].ft2</xsl:when>
				<xsl:when test=".='tonfUK/ft'">tonf[UK]/ft</xsl:when>
				<xsl:when test=".='tonfUK/ft2'">tonf[UK]/ft2</xsl:when>
				<xsl:when test=".='tonfUS'">tonf[US]</xsl:when>
				<xsl:when test=".='tonfUS.ft'">tonf[US].ft</xsl:when>
				<xsl:when test=".='tonfUS.ft2'">tonf[US].ft2</xsl:when>
				<xsl:when test=".='tonfUS.mi'">tonf[US].mi</xsl:when>
				<xsl:when test=".='tonfUS.mi/bbl'">tonf[US].mi/bbl</xsl:when>
				<xsl:when test=".='tonfUS.mi/ft'">tonf[US].mi/ft</xsl:when>
				<xsl:when test=".='tonfUS/ft'">tonf[US]/ft</xsl:when>
				<xsl:when test=".='tonfUS/ft2'">tonf[US]/ft2</xsl:when>
				<xsl:when test=".='tonfUS/in2'">tonf[US]/in2</xsl:when>
				<xsl:when test=".='ucal/s.cm2'">ucal[th]/(s.cm2)</xsl:when>
				<xsl:when test=".='ucurie'">uCi</xsl:when>
				<xsl:when test=".='umHg(0C)'">umHg[0degC]</xsl:when>
				<xsl:when test=".='volpercent'">%[vol]</xsl:when>
				<xsl:when test=".='volppm'">ppm[vol]</xsl:when>
				<xsl:when test=".='wtpercent'">%[mass]</xsl:when>
				<xsl:when test=".='wtppm'">ppm[mass]</xsl:when>
				<xsl:when test=".='ydBnA'">yd[BnA]</xsl:when>
				<xsl:when test=".='ydBnB'">yd[BnB]</xsl:when>
				<xsl:when test=".='ydCla'">yd[Cla]</xsl:when>
				<xsl:when test=".='ydIm'">yd[Cla]</xsl:when>
				<xsl:when test=".='ydInd'">yd[Ind]</xsl:when>
				<xsl:when test=".='ydInd(37)'">yd[Ind37]</xsl:when>
				<xsl:when test=".='ydInd(62)'">yd[Ind62]</xsl:when>
				<xsl:when test=".='ydInd(75)'">yd[Ind75]</xsl:when>
				<xsl:when test=".='ydSe'">yd[Se]</xsl:when>
				<xsl:when test=".='yr(100k)'">100 ka[t]</xsl:when>
				<xsl:otherwise>
					<xsl:value-of select="."/>
				</xsl:otherwise>
			</xsl:choose>
		</xsl:attribute>
	</xsl:template>
	<xsl:template match="@*|node()">
		<xsl:copy>
			<xsl:apply-templates select="@*|node()"/>
		</xsl:copy>
	</xsl:template>
</xsl:stylesheet>
