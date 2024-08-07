import React,{useState} from 'react'
import pic from "../Assets/pic4.jpg"
import Navbar from '../Components/Navbar'
import { useDispatch } from 'react-redux'
import axios from 'axios'
import {setFacilities} from '../state/State'
import { useNavigate } from 'react-router'
import logo from "../Assets/logo11.jpg"
import { Link } from 'react-router-dom'
function LandingPage() {
    const dispatch = useDispatch() 
    const navigate = useNavigate()
const [city , setCity]= useState('')
const handleSubmit =async  ()=>{
    var facilities = await  axios.get('https://localhost:7108/GetByCity',{
        City: city
    })
    if(facilities){
            dispatch(setFacilities({
                Facilities: facilities.data
            }))
        navigate('/Main')
    }
    console.log(city);

}


  return (
    <>
        <Navbar/>
    <section class="relative py-16 lg:py-16 bg-white">
    <div class="mx-auto lg:max-w-7xl w-full px-5 sm:px-10 md:px-12 lg:px-5 flex flex-col lg:flex-row gap-10 lg:gap-12">
        <div class="absolute w-full lg:w-1/2 inset-y-0 lg:right-0 hidden lg:block">
            <span class="absolute -left-6 md:left-4 top-24 lg:top-28 w-24 h-24 rotate-90 skew-x-12 rounded-3xl bg-green-400 blur-xl opacity-60 lg:opacity-95 lg:block hidden"></span>
            <span class="absolute right-4 bottom-12 w-24 h-24 rounded-3xl bg-blue-600 blur-xl opacity-80"></span>
        </div>
        <span class="w-4/12 lg:w-2/12 aspect-square bg-gradient-to-tr from-blue-600 to-green-400 absolute -top-5 lg:left-0 rounded-full skew-y-12 blur-2xl opacity-40 skew-x-12 rotate-90"></span>
        <div class="relative flex flex-col items-center text-center lg:text-left lg:py-7 xl:py-8
            lg:items-start lg:max-w-none max-w-3xl mx-auto lg:mx-0 lg:flex-1 lg:w-1/2">

            <h1 class="text-3xl leading-tight sm:text-4xl md:text-5xl xl:text-6xl
            font-bold text-gray-900">
                Real Estate   <span class="text-transparent bg-clip-text bg-gradient-to-br from-indigo-600 from-20% via-blue-600 via-30% to-green-600">Excellence</span>
                 Unleashed:
            </h1>
            <p class="mt-8 text-gray-700">
                Discover a world of unparalleled real estate excellence with.
                Whether you're buying, selling, or dreaming, our team is here to turn your vision into reality. Explore our curated listings, each with its own unique story. From cozy starter homes to luxurious estates, find the perfect match for your lifestyle.
            </p>
            <div class="mt-10  w-full flex max-w-md mx-auto lg:mx-0">
                <div class="flex sm:flex-row flex-col gap-5 w-full">
                    <form action="#"
                          class="py-1 pl-6 w-full pr-1 flex gap-3 items-center text-gray-600 shadow-lg shadow-gray-200/20
                            border border-gray-200 bg-gray-100 rounded-full ease-linear focus-within:bg-white  focus-within:border-blue-600">
                        <span class="min-w-max pr-2 border-r border-gray-200">
 
                            <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="w-6 h-6">
                                <path stroke-linecap="round" stroke-linejoin="round" d="m21 21-5.197-5.197m0 0A7.5 7.5 0 1 0 5.196 5.196a7.5 7.5 0 0 0 10.607 10.607Z" />
                            </svg> 

                        </span>
                        <input onChange={(e)=>setCity(e.target.value)} type="text" name="" id="" placeholder="CasaBlanca"
                               class="w-full py-3 border border-none  outline-none bg-transparent"/>
                        <button type='submit'  class="flex text-white justify-center items-center w-max min-w-max sm:w-max px-6 h-12 rounded-full outline-none relative overflow-hidden border duration-300 ease-linear
                                after:absolute after:inset-x-0 after:aspect-square after:scale-0 after:opacity-70 after:origin-center after:duration-300 after:ease-linear after:rounded-full after:top-0 after:left-0 after:bg-[#172554] hover:after:opacity-100 hover:after:scale-[2.5] bg-blue-600 border-transparent hover:border-[#172554]">
                            <Link to="/Main"class="hidden sm:flex relative z-[5]">
                                Search By city Name
                            </Link>
                            <span class="flex sm:hidden relative z-[5]">
                                <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24"
                                     stroke-width="1.5" stroke="currentColor" class="w-5 h-5">
                                    <path stroke-linecap="round" stroke-linejoin="round"
                                          d="M6 12L3.269 3.126A59.768 59.768 0 0121.485 12 59.77 59.77 0 013.27 20.876L5.999 12zm0 0h7.5" />
                                </svg>
                            </span>
                        </button>
                    </form>
                </div>
            </div>
        </div>
        <div class="flex flex-1 lg:w-1/2 lg:h-auto relative lg:max-w-none lg:mx-0 mx-auto max-w-3xl">
            <img src={pic} alt="Hero image" width="2350" height="2359"
                 class="lg:absolute lg:w-full lg:h-full rounded-3xl object-cover lg:max-h-none max-h-96"/>
        </div>
    </div>
</section>
    </>
  )
}

export default LandingPage
