function CanHaveClass__CssFriendlyAdapters(a){return a!=null&&a.className!=null}function HasAnyClass__CssFriendlyAdapters(a){return CanHaveClass__CssFriendlyAdapters(a)&&a.className.length>0}function HasClass__CssFriendlyAdapters(a,b){return HasAnyClass__CssFriendlyAdapters(a)&&a.className.indexOf(b)>-1}function AddClass__CssFriendlyAdapters(a,b){if(HasAnyClass__CssFriendlyAdapters(a)){if(!HasClass__CssFriendlyAdapters(a,b))a.className=a.className+" "+b}else if(CanHaveClass__CssFriendlyAdapters(a))a.className=b}function AddClassUpward__CssFriendlyAdapters(b,d,c){var a=b;while(a!=null&&!HasClass__CssFriendlyAdapters(a,topmostClass)){AddClass__CssFriendlyAdapters(a,c);a=a.parentNode}}function SwapClass__CssFriendlyAdapters(a,c,b){if(HasAnyClass__CssFriendlyAdapters(a))a.className=a.className.replace(new RegExp(c,"gi"),b)}function SwapOrAddClass__CssFriendlyAdapters(a,c,b){if(HasClass__CssFriendlyAdapters(a,c))SwapClass__CssFriendlyAdapters(a,c,b);else AddClass__CssFriendlyAdapters(a,b)}function RemoveClass__CssFriendlyAdapters(b,a){SwapClass__CssFriendlyAdapters(b,a,"")}function RemoveClassUpward__CssFriendlyAdapters(c,d,b){var a=c;while(a!=null&&!HasClass__CssFriendlyAdapters(a,topmostClass)){RemoveClass__CssFriendlyAdapters(a,b);a=a.parentNode}}function IsEnterKey(){var b=false,a=0;if(typeof window.event!="undefined"&&window.event!=null)a=window.event.keyCode;else if(typeof e!="undefined"&&e!=null)a=e.which;if(a==13)b=true;return b}