// OverlayScrollbars Configure
const SELECTOR_SIDEBAR_WRAPPER = '.sidebar-wrapper';
const Default = {
    scrollbarTheme: 'os-theme-light',
    scrollbarAutoHide: 'leave',
    scrollbarClickScroll: true,
};
function applySidebarState() {
    const body = document.body;
    const storedState = localStorage.getItem('sidebar-state');
    if (storedState === 'closed') {
        body.classList.remove('sidebar-open');
        body.classList.add('sidebar-collapse');
    }
}

// Apply sidebar state as early as possible
if (document.readyState === 'loading') {
    document.addEventListener('DOMContentLoaded', applySidebarState);
} else {
    applySidebarState();
}

document.addEventListener('DOMContentLoaded', function () {
    const sidebarWrapper = document.querySelector(SELECTOR_SIDEBAR_WRAPPER);
    if (sidebarWrapper && OverlayScrollbarsGlobal?.OverlayScrollbars !== undefined) {
        OverlayScrollbarsGlobal.OverlayScrollbars(sidebarWrapper, {
            scrollbars: {
                theme: Default.scrollbarTheme,
                autoHide: Default.scrollbarAutoHide,
                clickScroll: Default.scrollbarClickScroll,
            },
        });
    }

    // Save sidebar state whenever it's toggled
    const sidebarToggler = document.querySelector('[data-lte-toggle="sidebar"]');
    if (sidebarToggler) {
        sidebarToggler.addEventListener('click', () => {
            // Delay to allow AdminLTE to update classes
            setTimeout(() => {
                const isClosed = document.body.classList.contains('sidebar-collapse');
                localStorage.setItem('sidebar-state', isClosed ? 'closed' : 'open');
            }, 10);
        });
    }
});

// EnterキーでTab移動、Shift+Enterで逆方向に移動
document.addEventListener('keydown', function (e) {
    if (e.key !== 'Enter' || e.isComposing) {
        return;
    }

    const target = e.target;
    if (!(target instanceof HTMLElement) || !target.matches('input, select, textarea')) {
        return;
    }

    e.preventDefault();

    const focusableSelector = 'a[href], button, input, select, textarea, [tabindex]:not([tabindex="-1"])';
    const focusable = Array.from(document.querySelectorAll(focusableSelector))
        .filter(el => !el.hasAttribute('disabled') && el.getAttribute('tabindex') !== '-1' && el.offsetParent !== null);
    const index = focusable.indexOf(target);
    const next = e.shiftKey ? focusable[index - 1] : focusable[index + 1];
    if (next) {
        next.focus();
    }
});
