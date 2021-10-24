import { assertEquals } from "https://deno.land/std@0.63.0/testing/asserts.ts"
import * as _ from "../src/floor.js"

Deno.test("floor",() => {
    assertEquals(_.floor(4.006), 4)
    assertEquals(_.floor(0.046, 2), 2)
    assertEquals(_.floor(4060, -2), 4000)
})