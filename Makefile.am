SUBDIRS = codyn

pkgconfigdir = $(libdir)/pkgconfig
pkgconfig_DATA = codyn-sharp-@CODYN_SHARP_API_VERSION@.pc

codyn-sharp-@CODYN_SHARP_API_VERSION@.pc: codyn-sharp.pc
	cp $? $@

updateapi:
	gapi2-parser sources.xml && \
	rm -rf codyn/generated codyn/codyn-api.xml && \
	make -C codyn codyn-api.xml && \
	make -C codyn generated/Node.cs

EXTRA_DIST = 			\
	codyn-sharp.pc.in

CLEANFILES = codyn-sharp.pc codyn-sharp-@CODYN_SHARP_API_VERSION@.pc

