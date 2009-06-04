RAW_API = cpg-network-api.raw

API=cpg-network-api.xml
METADATA = CpgNetwork.metadata
ASSEMBLY_NAME = cpg-network-sharp
references = $(GLIB_SHARP_LIBS)

TARGET = $(ASSEMBLY)
ASSEMBLY = $(ASSEMBLY_NAME).dll
gapidir = $(datadir)/gapi-2.0
noinst_DATA = $(ASSEMBLY)
gapi_DATA = $(API)
CLEANFILES = $(ASSEMBLY) generated-stamp generated/*.cs $(API)
DISTCLEANFILES = AssemblyInfo.cs $(ASSEMBLY).mdb

sources =

build_sources = $(addprefix $(srcdir)/, $(sources)) AssemblyInfo.cs

customs = Monitor.custom

build_customs = $(addprefix $(srcdir)/, $(customs))

EXTRA_DIST =			\
	AssemblyInfo.cs.in	\
	$(RAW_API)		\
	$(METADATA)		\
	$(customs)		\
	$(sources)

$(API): $(srcdir)/$(RAW_API) $(srcdir)/$(METADATA)
	cp $(srcdir)/$(RAW_API) $(API)
	chmod u+w $(API)
	$(GAPI_FIXUP) --api=$(API) --metadata=$(srcdir)/$(METADATA)

generated-stamp: $(API) $(build_customs)
	rm -f generated/* &&	\
	$(GAPI_CODEGEN) --generate $(API) --outdir=generated --customdir=$(srcdir) --assembly-name=$(ASSEMBLY_NAME) 	\
	&& touch generated-stamp

$(ASSEMBLY): $(build_sources) generated-stamp
	$(CSC) -debug -unsafe /out:$(ASSEMBLY) $(CSFLAGS) /target:library $(references) $(build_sources) generated/*.cs

all: $(ASSEMBLY) $(TEST_TARGETS)

install-data-local:
	@if test -n '$(TARGET)'; then									\
	  echo "$(GACUTIL) /i $(ASSEMBLY) /f /package $(PACKAGE) /root $(DESTDIR)$(prefix)/lib";		\
	  $(GACUTIL) /i $(ASSEMBLY) /f /package $(PACKAGE) /root $(DESTDIR)$(prefix)/lib || exit 1;		\
	fi

uninstall-local:
	@if test -n '$(TARGET)'; then									\
	  echo "$(GACUTIL) /u $(ASSEMBLY_NAME) /package $(PACKAGE) /root $(DESTDIR)$(prefix)/lib";		\
	  $(GACUTIL) /u $(ASSEMBLY_NAME) /package $(PACKAGE) /root $(DESTDIR)$(prefix)/lib || exit 1;	\
	fi
