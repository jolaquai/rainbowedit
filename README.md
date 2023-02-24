# *rainbowedit*
*rainbowedit* is a little project I maintain mainly for my own convenience. It contains all the gameplay-relevant information you could ever want, plus some stuff you can use to build your own apps.

# Features
- Complete and up-to-date collection of all `Operator`s, including their weapon / gadget selection and some bio data and stats (actually, up-to-date usually before the update even comes out)
- Randomizer methods you can control (to some degree) to;
  - Generate a collection of random `Operators` (ensuring no duplicates while choosing a set number of `Operators` or by creating a pool of `Operators` to pick from yourself)
  - Generate loadout or weapon configurations
- Challenge generator methods (which are at least partially in the style of *Ubisoft Connect* challenges)
- Full documentation of all public members (there isn't that much private/internal stuff anyway, mostly implementation-specific stuff and things like `IEnumerable<T>` and `IEnumerator<T>` interface implementations)

# How to use

Using the library is pretty straightforward, either you
- use the source as-is in your own solution,
- build it and reference the resulting DLL or
- build it and package it as a nupkg and reference *that*.
I'm not putting this on NuGet, absolutely not important, useful or known enough to necessitate that.

# Contribution
Considering how small this library is (relatively speaking), I can confidently say I don't need help maintaining it in its current state.

However, if there is something you feel is missing and deserves to be in it, feel free! Fork it, add your modifications and create a pull request! I'll take a look at any contributions made and add them if I deem them appropriate.

## Contribution rules
- All public members must be fully documented. Link to Types you reference directly or indirectly using `<see />` tags wherever appropriate (use mine as a reference).
- Breaking changes:
  - If your additions contain breaking changes (as a very drastic example, renaming namespaces or renaming Types), your pull request must be labeled <span style="color: #D93F0B">`breaking`</span> and contain a justification as to why the change is necessary to implement your additions.
  - If your pull request lacks a justification as described, it will be labeled <span style="color: #D93F0B">`needs-justification`</span>.
- Stay up-to-date on your pull requests:
  - You may be asked for more information (your pull request will be labeled <span style="color: #D876E3">`waiting-for-info`</span> and <span style="color: #FBCA04">`on-hold`</span>) or to change specific details about your additions / implementations (your pull request will be labeled just <span style="color: #FBCA04">`on-hold`</span>).
  - If you don't respond (or at least update your pull requests with more commits that match what was requested) within a reasonable timeframe, your pull request will be rejected and labeled as such (<span style="color: #CCCCCC">`rejected`</span>).
  - You may label your pull request <span style="color: #008672">`help-wanted`</span> to let potential helpers know you need help with your pull request.<a href="#footnote-1"><span id="footnote-1-ref">[1]</span></a>

# Footnotes
<a href="#footnote-1-ref"><span id="footnote-1">1</span></a> A pull request may NOT be labeled <span style="color: #D876E3">`waiting-for-info`</span> and <span style="color: #008672">`help-wanted`</span> in that specific order. This is to prevent "out-sourcing" finding a solution to a situation you've gotten yourself into. I'm serious, this will get your pull request insta-<span style="color: #CCCCCC">`rejected`</span>.
