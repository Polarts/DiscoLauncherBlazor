const RECT_COUNT = 10;
const RECT_GAP = 6;

export function ProgressBar(rootElement, dotNetObjRef) {
    const clientRect = rootElement.getBoundingClientRect();
    const rectWidth = (clientRect.width / RECT_COUNT) - RECT_GAP;
    rootElement.style.setProperty('--rect-width', rectWidth+'px');
}