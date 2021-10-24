import { assertEquals } from "https://deno.land/std@0.63.0/testing/asserts.ts"
import * as _ from "../src/isArray.js"

Deno.test("isArray",() => {
    assertEquals(_.isArray([1, 2, 3]), true)
    assertEquals(_.isArray(document.body.children), false)
    assertEquals(_.isArray('abc'), false)
    assertEquals(_.isArray(_.noop), false)
})