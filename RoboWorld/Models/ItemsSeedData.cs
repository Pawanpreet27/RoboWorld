using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;


namespace RoboWorld.Models
{
    public class ItemsSeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Items.Any())
            {
                context.Items.AddRange(
                new Item
                {
                    ItemName = "VTech Kidizoom Smartwatch DX2, Purple ",
                    Description = "The perfect tech for kids, Kidizoom Smartwatch DX2 by VTECH lets them take pictures, videos, play games, tell time and more! featuring a new sleek and stylish design, this durable Smartwatch includes 55 digital and analog customizable watch faces to help kids learn to tell time. This Smartwatch features two cameras that allow your child to capture everything from action video to selfies that can be customized in the silly me app and made into new watch faces. Includes an assortment of new games including Monster detector, which uses the camera and Augmented reality to help kids find and capture monsters in the real world. Kids can also use the watch's motion sensor for active play challenges or to track steps. Using the included micro-usb cable, upload photos and videos as well as recharge the battery. The Kidizoom Smartwatch DX2 is a great multifunction watch like mom and dad's, designed just for kids!",
                    Price = 60.99,
                    Category = "Wearables",
                    ImagePath = "item1.png"
                },

                new Item
                {
                    ItemName = "Snap Circuits CM-200 203 Electronics Discovery Kit ",
                    Description = "Circuit Maker Skill Builder covers 203 projects with exciting electronics concepts. Circuit Maker kits make learning electronics fun and easy but engaging. No bored kids here. All components are mounted in plastic modules and snap together with ease. Enjoy hours of educational fun while learning about electronics and building analytical and problem solving skills.",
                    Price = 49.99,
                    Category = "Circuits",
                    ImagePath = "item2.png"
                },

                 new Item
                 {
                     ItemName = "Biological Microscope Kit Metal Arm and base ",
                     Description = "With this 48-piece microscope set young scientists can investigate everything from cells to crystals. Perfect for individual or classroom use the glass eyepieces and power settings 120X, 240X, 300X, 480X, 600X and 1200X provide users with superior precision viewing. The built-in natural light through the mirror and LED powered by two AA batteries illumination system and rack-and-pinion focusing help deliver bright clear images. The 48-piece kit has professionally prepared slides and everything users need to make their own specimen slides. The microscope has a durable metal arm single coaxial coarse focusing and specimen stage with two built-in stage clips. It includes high-quality components and features that make it appropriate for science learning at any age. The kit comes with sample slides cover slips tweezers scalpel specimen vials adjustable lenses collecting lamps plus a sturdy hard case for easy storage and travel. This kit is great for beginning scientists. Two AA batteries for LED light are included.Features. 120X, 240X, 300X, 480X, 600X and 1200X six magnification beginner microscope with metal arm to support the unit.. Built-in light for direct illumination.. Reflecting mirror for natural illumination.. Battery compartment for 2 AA-size.. Built-in rotating color filter wheel.. Specimen stage with stage clips.. Includes - plastic scalpel plastic spatula plastic tweezers.. Dimension - 12.5 x 9 x 6 in.Specifications. Magnifications - 120X, 240X, 300X, 480X, 600X and 1200X. Body Type - durable metal construction.. Illumination - built-in LED light and reflecting mirror.. Eyepiece - holder type single.. Stage - 70 x 65mm.. Slide Holder - dual spring clips.. Accessory Set - 1 specimen slicer 1 petri dish 1 plastic tweezer 1 spare bulb 1 plastic scalpel 1 plastic spatula 1 needle 1 plastic stirring rod 1 eosin 5 prepared slides 7 blank slides 16 slide covers 8 slide.",
                     Price = 20.49,
                     Category = "Educational",
                     ImagePath = "item3.png"
                 },

                new Item
                {
                    ItemName = "APUPPY Kids Piggy Bank with electronic lock",
                    Description = "It’s a fun and educational money saving bank, devolop your kids money saving concept,cultivate the good habit of saving.Exquisite design, the appearance of cute,Is the best choice for gift gifts.",
                    Price = 89.99,
                    Category = "Educational",
                    ImagePath = "item4.png"
                },

               new Item
               {
                   ItemName = "Fisca Remote Control Dog, RC Robotic Stunt Puppy",
                   Description = "intelligent remote control robotic stunt dog made of high-quality plastic with smooth surface has Voice Control, Interaction Function, Dancing Function, Program, Demo, it would make a great gift for your kids.",
                   Price = 120.99,
                   Category = "Remote Control",
                   ImagePath = "item5.png"
               },

               new Item
               {
                   ItemName = "Trimnpy RC Cars Robot for Kids Remote Control Car",
                   Description = "remote-controlled deformation car provides lots of fun for kids who love cars and robot! Bring children a different racing experience. Simple controls offer a one button transformation so your child can start playing with no learning curve.",
                   Price = 149.99,
                   Category = "Remote Control",
                   ImagePath = "item6.png"
               },

               new Item
               {
                   ItemName = " D20 Mini Drone Foldable for Kids with HD Camera",
                   Description = "HD Pictures and Live Videos: D20 equipped with 720P HD Wi-Fi camera to take better aerial photos and videos; with FPV transmission, you can see the sky from a live video feed through smartphone app.",
                   Price = 59.99,
                   Category = "Remote Control",
                   ImagePath = "item7.png"
               },

               new Item
               {
                   ItemName = "HS165 GPS FPV Drones with Camera 2K HD",
                   Description = "SAFE GPS RETURN HOME-- Do not worry about losing the drone with GPS positioning, it can return to home precisely whenever it runs out of power or loses connection in the GPS mode or you press one key return.",
                   Price = 99.99,
                   Category = "Remote Control",
                   ImagePath = "item8.png"
               },

               new Item
               {
                   ItemName = "Power Rangers Beast Morphers Beast-X",
                   Description = "The Power Rangers Beast Morphers Beast-X King Morpher features lights and over 20 sounds and phrases (English)",
                   Price = 19.98,
                   Category = "Wearables",
                   ImagePath = "item9.png"
               }
             );
                context.SaveChanges();
            }
        }
    }
}
