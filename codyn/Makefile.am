RAW_API = codyn-api.raw

API = codyn-api.xml
METADATA = Codyn.metadata
ASSEMBLY_NAME = Codyn
references = $(GLIB_SHARP_LIBS)

TARGET = $(ASSEMBLY)
ASSEMBLY = $(ASSEMBLY_NAME).dll
noinst_DATA = $(ASSEMBLY)
CLEANFILES = $(ASSEMBLY) generated-stamp generated/*.cs $(API)
DISTCLEANFILES = AssemblyInfo.cs $(ASSEMBLY).mdb

SYMBOLS = codyn.symbols
build_symbols = $(addprefix --symbols=$(srcdir)/, $(SYMBOLS))

sources =

overrides = \
	MiniObject.cs \
	CdnSharp.MiniObjectCopyFunctionNative.cs \
	CdnSharp.MiniObjectFinalizeFunctionNative.cs

build_sources = $(addprefix $(srcdir)/, $(sources)) AssemblyInfo.cs
overrides_sources = $(addprefix $(srcdir)/, $(overrides))

customs = \
	Monitor.custom \
	FunctionPolynomialPiece.custom \
	Expression.custom \
	ExpressionTreeIter.custom \
	Node.custom \
	EdgeAction.custom \
	Property.custom \
	FunctionArgument.custom \
	InputFile.custom \
	Variable.custom \
	InstructionFunction.custom \
	Operator.custom

build_customs = $(addprefix $(srcdir)/, $(customs))

EXTRA_DIST =			\
	AssemblyInfo.cs.in	\
	$(RAW_API)		\
	$(METADATA)		\
	$(customs)		\
	$(sources)		\
	$(SYMBOLS)		\
	$(overrides)

if HAS_GAPI_FIXUP
$(API): $(srcdir)/$(RAW_API) $(srcdir)/$(METADATA) $(SYMBOLS)
	cp $(srcdir)/$(RAW_API) $(API)
	chmod u+w $(API)
	$(GAPI_FIXUP) --api=$(API) --metadata=$(srcdir)/$(METADATA) $(build_symbols)
endif

if HAS_GAPI_CODEGEN
generated-stamp: $(API) $(build_customs) $(overrides_sources)
	rm -f generated/* &&	\
	$(GAPI_CODEGEN) --generate $(API) --outdir=generated --customdir=$(srcdir) --assembly-name=$(ASSEMBLY_NAME) 	\
	&& cp $(overrides_sources) generated/ \
	&& touch generated-stamp
else
generated-stamp:
	touch generated-stamp
endif

$(ASSEMBLY): $(build_sources) generated-stamp
	$(CSC) -debug -unsafe /out:$(ASSEMBLY) $(CSFLAGS) /target:library $(references) $(build_sources) generated/*.cs

all: $(ASSEMBLY)

codynsharpdir=$(libdir)/codyn-sharp-@CODYN_SHARP_API_VERSION@
codynsharp_SCRIPTS = $(ASSEMBLY_NAME).dll
