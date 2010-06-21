RAW_API = cpg-network-api.raw

API = cpg-network-api.xml
METADATA = CpgNetwork.metadata
ASSEMBLY_NAME = CpgNetwork
references = $(GLIB_SHARP_LIBS)

TARGET = $(ASSEMBLY)
ASSEMBLY = $(ASSEMBLY_NAME).dll
noinst_DATA = $(ASSEMBLY)
CLEANFILES = $(ASSEMBLY) generated-stamp generated/*.cs $(API)
DISTCLEANFILES = AssemblyInfo.cs $(ASSEMBLY).mdb

SYMBOLS = cpg-network-symbols.xml
build_symbols = $(addprefix --symbols=$(srcdir)/, $(SYMBOLS))

sources = \
	Instruction.cs \
	InstructionCustomFunction.cs \
	InstructionFunction.cs \
	InstructionNumber.cs \
	InstructionProperty.cs \
	InstructionOperator.cs

build_sources = $(addprefix $(srcdir)/, $(sources)) AssemblyInfo.cs

customs = \
	Monitor.custom \
	FunctionPolynomialPiece.custom \
	Integrator.custom \
	Expression.custom

build_customs = $(addprefix $(srcdir)/, $(customs))

EXTRA_DIST =			\
	AssemblyInfo.cs.in	\
	$(RAW_API)		\
	$(METADATA)		\
	$(customs)		\
	$(sources)		\
	$(SYMBOLS)

$(API): $(srcdir)/$(RAW_API) $(srcdir)/$(METADATA) $(SYMBOLS)
	cp $(srcdir)/$(RAW_API) $(API)
	chmod u+w $(API)
	$(GAPI_FIXUP) --api=$(API) --metadata=$(srcdir)/$(METADATA) $(build_symbols)

generated-stamp: $(API) $(build_customs)
	rm -f generated/* &&	\
	$(GAPI_CODEGEN) --generate $(API) --outdir=generated --customdir=$(srcdir) --assembly-name=$(ASSEMBLY_NAME) 	\
	&& touch generated-stamp

$(ASSEMBLY): $(build_sources) generated-stamp
	$(CSC) -debug -unsafe /out:$(ASSEMBLY) $(CSFLAGS) /target:library $(references) $(build_sources) generated/*.cs

all: $(ASSEMBLY)

cpgnetworksharpdir=$(libdir)/cpg-network-sharp-@CPG_NETWORK_SHARP_API_VERSION@
cpgnetworksharp_SCRIPTS = $(ASSEMBLY_NAME).dll
