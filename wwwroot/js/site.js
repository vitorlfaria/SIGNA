document.addEventListener('DOMContentLoaded', () => {
    document.querySelectorAll('.nav-link').forEach(link => {
        const locationArr = location.pathname.toLowerCase().split('/')
        const linkArr = link.getAttribute('href').toLowerCase().split('/')

        locationArr.shift()
        linkArr.shift()

        if (locationArr.includes(linkArr[0])) {
            link.classList.add('active-link')
        } else {
            link.classList.remove('active-link')
        }
    })
})