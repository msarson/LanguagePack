[marketplace]: https://marketplace.visualstudio.com/items?itemName=MadsKristensen.LanguagePack
[vsixgallery]: http://vsixgallery.com/extension/LanguagePack.da8ee435-6f16-40c1-a2e0-be6989294391/
[repo]:https://github.com/madskristensen/LanguagePack

# Syntax Booster Pack for Visual Studio

[![Build](https://github.com/madskristensen/LanguagePack/actions/workflows/build.yaml/badge.svg)](https://github.com/madskristensen/LanguagePack/actions/workflows/build.yaml)
![GitHub Sponsors](https://img.shields.io/github/sponsors/madskristensen)

Download this extension from the [Visual Studio Marketplace][marketplace] or get the [CI build][vsixgallery]

----------------------------------------

This extension enhances Visual Studio by adding syntax highlighting, code folding, and basic IntelliSense for various file types that aren't natively supported.

It helps you work with specialized or emerging languages without leaving your preferred IDE. The language pack is lightweight and integrates seamlessly with the Visual Studio interface, maintaining a consistent development experience.

> Includes syntaxes from the [textmate-grammars-themes](https://github.com/shikijs/textmate-grammars-themes) repo.

## Add missing languages
If you are missing a language, please open an issue or send a pull request to this repository. The goal is to include as many languages as possible in this extension. If a Textmate grammar exists for a language, it can be added to this extension, although some grammars might not be compatible with Visual Studio.

If you send a PR, don't add a new file or folder to the .csproj. Simply place your language files in the `Grammars` folder. VS should automatically detect them. You may need to close and reopen the solution in VS to see the changes.

Before suggesting a language, check Visual Studio’s built-in languages. This extension isn’t intended to replace built-in languages, but to add support for those that aren’t natively supported. You can find the built-in languages at:
`C:\Program Files\Microsoft Visual Studio\2022\Common7\IDE\CommonExtensions\Microsoft\TextMate\Starterkit\Extensions`

## Supported languages (128)

| Language | File Extensions |
|:---------|:---------------|
| ABAP | .abap |
| ActionScript 3 | .as |
| Apache | .conf, .htaccess, .htgroups, .htpasswd, .envvars |
| Apex | .cls, .apex |
| APL | .apl, .apla, .aplc, .aplf, .apli, .apln, .aplo, .dyalog, .dyapp, .mipage |
| ARA | .ara |
| ASP | .asa |
| HTML-ASP | .asp |
| AsciiDoc | .ad, .asc, .adoc, .asciidoc, .adoc.txt |
| Assembly | .asm, .s |
| Astro | .astro |
| AWK | .awk |
| Ballerina | .bal |
| Beancount | .beancount |
| Bicep | .bicep |
| Bond | .bond |
| BSL | .bsl, .os |
| Cake | .cake |
| Clarion | .clw, .equ, .inc, .int |
| COBOL | .cbl, .cob, .cpy, .copybook, .cobcopy |
| Coco/R | .atg |
| CodeQL | .ql, .qll |
| Common Lisp | .lisp, .cl |
| C++ Qt | .cpp, .h, .pri, .pro |
| Crystal | .cr |
| CSV | .csv |
| CUDA C++ | .cu, .cuh |
| CUE | .cue |
| Cypher | .cql, .cyp, .cypher |
| D | .d, .di |
| Dart | .dart |
| Diff | .diff, .patch |
| Dream Maker | .dm |
| Dust | .dust, .dustjs, .tl |
| Elixir | .ex, .exs, .eex |
| Elm | .elm |
| Emacs Lisp | .el |
| Erlang | .erl, .hrl, .yaws |
| EYAML | .eyaml |
| Fish | .fish |
| Fortran (Fixed Form) | .f, .for, .ftn |
| Fortran (Free Form) | .f90, .f95, .f03, .f08 |
| FoxPro | .prg |
| GDScript | .gd |
| GDShader | .gdshader |
| Genie | .gs |
| GetText | .po, .pot |
| Gherkin | .feature |
| Git | .git-commit, .git-config, .git-rebase |
| Gleam | .gleam |
| GLSL | .glsl, .vert, .frag |
| GN | .gn, .gni |
| Gnuplot | .plt, .gnuplot |
| Gradle | .gradle |
| GraphQL | .graphql, .gql |
| Hack | .hack, .hh |
| Haml | .haml |
| Haskell | .hs, .lhs |
| Haxe | .hx |
| HCL | .hcl, .tf, .tfvars, .nomad, .appfile |
| Hjson | .hjson |
| HLSL | .hlsl, .fx |
| HTTP | .http, .rest |
| HXML | .hxml |
| iCalendar | .ics, .ifb |
| Idris | .idr, .ipkg |
| Ignore | .gitignore |
| Imba | .imba |
| Inno Setup | .iss, .isl |
| Jison | .jison |
| JSSM | .jssm |
| Kotlin | .kt, .kts |
| Kusto | .kusto, .kql, .csl |
| LaTeX | .tex, .latex |
| Lex/Flex | .tex, .latex |
| BibTeX | .bib |
| LaTeX Beamer | .tex |
| LaTeX Log | .log |
| LaTeX Memoir | .tex |
| TeX | .tex |
| Liquid | .liquid, .lava |
| Lisp | .lisp, .lsp |
| Log | .log |
| Luau | .luau |
| MATLAB | .m |
| MDX | .mdx |
| MIPS Assembly | .s, .mips |
| Nginx | .nginx, .conf |
| Nim | .nim, .nimble |
| Nix | .nix |
| NSIS | .nsi, .nsh, .nlf, .nsl, .bridlensis |
| OCaml | .ml, .mli |
| Pascal | .pas, .p, .pp |
| PO | .po, .pot |
| PostCSS | .pcss |
| PostScript | .ps, .eps |
| PowerQuery | .pq, .pqm |
| Prisma | .prisma |
| Prolog | .pl, .pro |
| Puppet | .pp, .epp |
| PureScript | .purs |
| QML | .qml, .qmlproject |
| Razor | .cshtml, .razor |
| REG | .reg |
| RegExp | .regexp |
| RISC-V | .riscv, .s |
| JavaScript (Rails) | .js.erb |
| SQL (Rails) | .sql |
| SAS | .sas |
| Sass | .sass |
| Scala | .scala, .sc, .sbt |
| Scheme | .scm, .ss |
| SDBL | .sdbl |
| Slim | .slim, .skim |
| Solidity | .sol |
| Soy | .soy |
| SPARQL | .sparql, .rq |
| Splunk | .splunk |
| SSH Config | .ssh_config, .sshd_config |
| Stylus | .styl, .stylus |
| SystemVerilog | .sv, .svh |
| TASL | .tasl |
| Tcl | .tcl, .rc, .pre, .post, .csh, .tsch | 
| Terraform | .tf, .tfvars |
| Thrift | .thrift |
| Tick | .tick |
| TOML | .toml |
| TSV | .tsv |
| Turtle | .ttl |
| Twig | .twig |
| TypeSpec | .tsp |
| V | .v |
| Vala | .vala, .vapi |
| Verilog | .v, .vh |
| VHDL | .vhd, .vhdl, .vho |
| Wolfram | .wl, .wls, .nb |
| Wren | .wren |
| XQuery | .xq, .xql, .xqm, .xqy, .xquery |
| ZenScript | .zs |
| Zig | .zig |


## How can I help?  
If you enjoy using the extension, please give it a ★★★★★ rating on the [Visual Studio Marketplace][marketplace]. It only takes a few seconds but makes a huge difference!

Found a bug or have a feature idea? Head over to the [GitHub repo][repo] to open an issue if one doesn't already exist.

Pull requests are enthusiastically welcomed! As this is a personal passion project maintained in my spare time, I can't always address every issue promptly. Your contributions help keep this extension vibrant and reliable for everyone.

If you find this extension saves you time or improves your workflow, please consider [sponsoring me on GitHub](https://github.com/sponsors/madskristensen). Even a small donation helps ensure continued development and support. Your sponsorship directly enables me to dedicate more time to this and other free extensions for the community. Thank you for your support!