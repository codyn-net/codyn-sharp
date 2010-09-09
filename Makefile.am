SUBDIRS = cpg-network

pkgconfigdir = $(libdir)/pkgconfig
pkgconfig_DATA = cpg-network-sharp-@CPG_NETWORK_SHARP_API_VERSION@.pc

cpg-network-sharp-@CPG_NETWORK_SHARP_API_VERSION@.pc: cpg-network-sharp.pc
	cp $? $@

EXTRA_DIST = 			\
	cpg-network-sharp.pc.in	\
	sources.xml

CLEANFILES = cpg-network-sharp.pc cpg-network-sharp-@CPG_NETWORK_SHARP_API_VERSION@.pc 

