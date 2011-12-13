SUBDIRS = codyn

pkgconfigdir = $(libdir)/pkgconfig
pkgconfig_DATA = codyn-sharp-@CODYN_SHARP_API_VERSION@.pc

codyn-sharp-@CODYN_SHARP_API_VERSION@.pc: codyn-sharp.pc
	cp $? $@

EXTRA_DIST = 			\
	codyn-sharp.pc.in

CLEANFILES = codyn-sharp.pc codyn-sharp-@CODYN_SHARP_API_VERSION@.pc

