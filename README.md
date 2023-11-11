# Low Latency Image Changes Detection

### Here’s to the rebels ones!

As I said on Linkedin, I'm going to talk about one of the arts of software development,  

As usual, I use my mindset against the operating system, Yes, I have no rules, I have a mindset, 
When I want to do something, I do it, there are no limits to my imagination.


## Where is the problem? 

I used to use Anydesk / TeamViewer for remote administration, but I was always facing poor "Quality", bad connection for no reason, and a thousand disconnects per second, so? 


I created my own remote access tool, yep, do not be shocked, I stopped using a lot of official programs a long time ago, and yes, I just write what I want in my resume, not everything there, my knowledge In .NET is not limited to SQL Queries.. Programming Languages are just a TOOL, I am playing with it as I want ; )

## Where is the solution?

Here is it!

I wrote a simple way to detect changes In a screenshot Depending on GDI+ ( DOSE NOT DEPEND ON CUDA TOOLKIT OR OPENCL ), what does that mean?

I Will take a screenshot, then I will send it to the other side, after that I will take a new screenshot, convert it to "Blocks", and make a very quick comparing between the old screenshot blocks with the new ones, 

if you move a mouse into a new block or even inside the current block, I will take that "Blocks" only that changes happen inside it.

That will move your Full Screenshot ( 0.5 MB Almost ) into small and light-weight pieces, On average about 20-50 KB, I care more about quality than quantity;

This is the idea, no loops, sockets, or something huge happened, just the "Idea",  You can reach 60 FPS With this method ( Proof of concept available ), The most important thing is not just think, but to think differently!

## An example of changes:

1 - 1st Screenshot:

![](https://raw.githubusercontent.com/shadyelmaadawy/Low-Latency-Image-Changes-Detection/master/1.png)

2 - 2nd Screenshot: 

![](https://raw.githubusercontent.com/shadyelmaadawy/Low-Latency-Image-Changes-Detection/master/2.png)

3 - Compare result:

![](https://raw.githubusercontent.com/shadyelmaadawy/Low-Latency-Image-Changes-Detection/master/3.png)

![](https://raw.githubusercontent.com/shadyelmaadawy/Low-Latency-Image-Changes-Detection/master/4.png)

> NOTE: THIS IS A VIRTUAL MACHINE, IN A REAL DEVICE LATENCY SHOULD BE AROUND 3~5 ms

I think this code was written at the end of 2015, and was in the darkness for a long time, 

But today, I refining and rewriting It to bring it to the light and apply some changes that happened to me over the years.


## Shady’s Dilemma

> “What Happens in Vegas, Stays in Vegas”

I did not mention how to draw the changes that have happened, how to crop the changed blocks, or native APIs function that you will use to do that, 

As actions speak louder than words, I am abandoning that to all ‘experts’ out there with many years of experience with full-time job.
This is what a person with passion was able to do, Show me what you have ^_*

## Last thing!

stay tuned, winter is coming and when I am feeling Brrr, I am turned on!

‘Maybe’, I’m not sure about that, but someone will dive you into the Dark-Art of software development, an art never touched by amateur engineers or developers before ; )

# Credits
### Copyright (©) 2023, Shady K. Maadawy, All rights reserved.
  [@shadudiix](https://github.com/shadyelmaadawy)
